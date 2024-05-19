using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.OCR;
using Compunet.YoloV8;
using SixLabors.ImageSharp.PixelFormats;

namespace CanCuocCongDanDetect
{
    public partial class Detect : Form
    {
        private Image<Bgr, byte> _imgDefault;
        private Tesseract _ocr;
        private VideoCapture capture;
        private Bitmap ploted;
        private Mat frame;
        private string selectedFilePath;
        public Detect()
        {
            InitializeComponent();
        }
        private void openPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.PNG)|*.jpg; *.jpeg; *.bmp; *.PNG";
            if (open.ShowDialog() == DialogResult.OK)
            {
                _imgDefault = new Image<Bgr, byte>(open.FileName);
                ptbDefaultImage.Image = _imgDefault.ToBitmap();
                selectedFilePath = open.FileName;
            }
        }
        static Bitmap CropImage(Image originalImage, SixLabors.ImageSharp.Rectangle rect)
        {
            Bitmap croppedImage = new Bitmap(rect.Width + 1, rect.Height + 1);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(originalImage, new Rectangle(0, 0, rect.Width, rect.Height), rect.Left, rect.Top, rect.Width, rect.Height, GraphicsUnit.Pixel);
            }
            return croppedImage;
        }
        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load Model
            using var predictor = YoloV8Predictor.Create("../../../modelYolo/detectionCCCD.onnx");
            var result = predictor.Detect(selectedFilePath);
            Image image2 = Image.FromFile(selectedFilePath);
            ploted = CropImage(image2, result.Boxes[0].Bounds);
            ptbCropImage.Image = ploted;
        }
        public string PerformOcr(Image<Gray, byte> image)
        {
            string data = "";
            // Khởi tạo đối tượng OCR
            _ocr = new Tesseract(Path.GetFullPath("../../../tessdata/"), "vie", OcrEngineMode.TesseractOnly);
            Cursor.Current = Cursors.WaitCursor;
            _ocr.SetImage(image);
            _ocr.Recognize();
            data = _ocr.GetUTF8Text();
            // Nhận dạng văn bản từ hình ảnh
            _ocr?.Dispose();
            // Trả về kết quả
            return data;
        }
        // Hàm chuyển ảnh từ dạng Bitmap về ImageSharp để sử dụng Yolo
        public static SixLabors.ImageSharp.Image<Rgb24> ConvertToImageSharpImage(System.Drawing.Image systemDrawingImage)
        {
            using MemoryStream memoryStream = new MemoryStream();
            systemDrawingImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            memoryStream.Seek(0, SeekOrigin.Begin);
            return SixLabors.ImageSharp.Image.Load<Rgb24>(memoryStream);
        }
        // Hàm cắt hình
        public Bitmap cropFunction(Compunet.YoloV8.Data.DetectionResult resultText, string className)
        {
            SixLabors.ImageSharp.Rectangle desiredBounds = SixLabors.ImageSharp.Rectangle.Empty;
            // Duyệt qua tất cả các hộp giới hạn trong kết quả dự đoán
            foreach (var b in resultText.Boxes)
            {
                string currentClassName = b.Class.Name;

                // Kiểm tra xem tên lớp của hộp giới hạn có trùng với className không
                if (currentClassName == className)
                {
                    // Nếu trùng, lưu trữ thông tin của hộp giới hạn
                    desiredBounds = b.Bounds;
                    break;
                }
            }
            // Nếu tìm thấy, cắt hình ảnh và trả về
            return CropImage(ploted, desiredBounds);
        }
        private void reconizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var predictorText = YoloV8Predictor.Create("../../../modelYolo/detectionText.onnx");
            var resultText = predictorText.Detect(ConvertToImageSharpImage(ploted));

            var cropFace = new Bitmap(cropFunction(resultText, "Face"));
            var cropName = new Bitmap(cropFunction(resultText, "Full name"));
            var cropID = new Bitmap(cropFunction(resultText, "ID"));
            var cropBirthday = new Bitmap(cropFunction(resultText, "Date of birth"));
            var cropNationality = new Bitmap(cropFunction(resultText, "Nationality"));
            var cropSex = new Bitmap(cropFunction(resultText, "Sex"));
            var cropAddress1 = new Bitmap(cropFunction(resultText, "Place of residence 1"));
            var cropAddress2 = new Bitmap(cropFunction(resultText, "Place of residence 2"));
            var cropOrigin = new Bitmap(cropFunction(resultText, "Place of origin"));
            var cropDateExpired = new Bitmap(cropFunction(resultText, "Date of expiry"));
            var cropQR = new Bitmap(cropFunction(resultText, "QR"));
            try
            {
                ptbFace.Image = cropFace.ToImage<Bgr, byte>().ToBitmap();
                ptbQR.Image = cropQR.ToImage<Bgr, byte>().ToBitmap();
                tbNumber.Text = PerformOcr(cropID.ToImage<Gray, byte>().Resize(2, Inter.Linear).SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255)));
                tbName.Text = PerformOcr(cropName.ToImage<Gray, byte>().SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255)));
                tbBirthday.Text = PerformOcr(cropBirthday.ToImage<Gray, byte>().SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255)));
                tbGender.Text = PerformOcr(cropSex.ToImage<Gray, byte>().SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255)));
                tbNationality.Text = PerformOcr(cropNationality.ToImage<Gray, byte>().SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255)));
                tbOrigin.Text = PerformOcr(cropOrigin.ToImage<Gray, byte>().SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255)));
                tbAddress.Text = PerformOcr(cropAddress1.ToImage<Gray, byte>().SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255)));
                tbAddress.AppendText(", " + PerformOcr(cropAddress2.ToImage<Gray, byte>().SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255))));
                tbExpired.Text = PerformOcr(cropDateExpired.ToImage<Gray, byte>().SmoothGaussian(Convert.ToInt32(1)).ThresholdBinary(new Gray(90), new Gray(255)));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (capture != null && capture.Ptr != IntPtr.Zero)
            {
                frame = new Mat();
                capture.Retrieve(frame);
                ptbDefaultImage.Image = frame.ToBitmap();
            }
            else
            {
                MessageBox.Show("Camera của bạn đã bị lỗi, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capture = new VideoCapture();
            capture.ImageGrabbed += ProcessFrame;
            capture.Start();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capture.Stop();
            capture.Dispose();
            capture = null;
            ptbDefaultImage.Image = null; 
        }
        private void takePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool readSuccess = capture.Read(frame);
            ptbCropImage.Image = frame.ToBitmap();
            selectedFilePath = "../../../Resources/print.jpg";
            frame.Save(selectedFilePath);
        }
    }
}
