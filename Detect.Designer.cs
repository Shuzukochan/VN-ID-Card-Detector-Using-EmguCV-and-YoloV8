namespace CanCuocCongDanDetect
{
    partial class Detect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detect));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openWebcamToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            openPictureToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            cropToolStripMenuItem = new ToolStripMenuItem();
            reconizeToolStripMenuItem = new ToolStripMenuItem();
            takePhotoToolStripMenuItem = new ToolStripMenuItem();
            ptbDefaultImage = new PictureBox();
            ptbCropImage = new PictureBox();
            lbName = new Label();
            lbNumber = new Label();
            lbBirthday = new Label();
            lbGender = new Label();
            lbOrigin = new Label();
            lbNationality = new Label();
            lbAddress = new Label();
            tbName = new TextBox();
            tbNumber = new TextBox();
            tbBirthday = new TextBox();
            tbGender = new TextBox();
            tbNationality = new TextBox();
            tbOrigin = new TextBox();
            tbAddress = new TextBox();
            ptbFace = new PictureBox();
            lbExpired = new Label();
            tbExpired = new TextBox();
            ptbQR = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDefaultImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbCropImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbFace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbQR).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openWebcamToolStripMenuItem, openPictureToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openWebcamToolStripMenuItem
            // 
            openWebcamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, closeToolStripMenuItem });
            openWebcamToolStripMenuItem.Name = "openWebcamToolStripMenuItem";
            openWebcamToolStripMenuItem.Size = new Size(180, 22);
            openWebcamToolStripMenuItem.Text = "Webcam";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // openPictureToolStripMenuItem
            // 
            openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            openPictureToolStripMenuItem.Size = new Size(180, 22);
            openPictureToolStripMenuItem.Text = "Open Picture";
            openPictureToolStripMenuItem.Click += openPictureToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cropToolStripMenuItem, reconizeToolStripMenuItem, takePhotoToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // cropToolStripMenuItem
            // 
            cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            cropToolStripMenuItem.Size = new Size(132, 22);
            cropToolStripMenuItem.Text = "Crop";
            cropToolStripMenuItem.Click += cropToolStripMenuItem_Click;
            // 
            // reconizeToolStripMenuItem
            // 
            reconizeToolStripMenuItem.Name = "reconizeToolStripMenuItem";
            reconizeToolStripMenuItem.Size = new Size(132, 22);
            reconizeToolStripMenuItem.Text = "Reconize";
            reconizeToolStripMenuItem.Click += reconizeToolStripMenuItem_Click;
            // 
            // takePhotoToolStripMenuItem
            // 
            takePhotoToolStripMenuItem.Name = "takePhotoToolStripMenuItem";
            takePhotoToolStripMenuItem.Size = new Size(132, 22);
            takePhotoToolStripMenuItem.Text = "Screenshot";
            takePhotoToolStripMenuItem.Click += takePhotoToolStripMenuItem_Click;
            // 
            // ptbDefaultImage
            // 
            ptbDefaultImage.Anchor = AnchorStyles.None;
            ptbDefaultImage.Location = new Point(15, 71);
            ptbDefaultImage.Name = "ptbDefaultImage";
            ptbDefaultImage.Size = new Size(450, 296);
            ptbDefaultImage.SizeMode = PictureBoxSizeMode.Zoom;
            ptbDefaultImage.TabIndex = 1;
            ptbDefaultImage.TabStop = false;
            // 
            // ptbCropImage
            // 
            ptbCropImage.Anchor = AnchorStyles.None;
            ptbCropImage.Location = new Point(514, 71);
            ptbCropImage.Name = "ptbCropImage";
            ptbCropImage.Size = new Size(450, 296);
            ptbCropImage.SizeMode = PictureBoxSizeMode.Zoom;
            ptbCropImage.TabIndex = 2;
            ptbCropImage.TabStop = false;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.None;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.Location = new Point(177, 415);
            lbName.Name = "lbName";
            lbName.Size = new Size(77, 20);
            lbName.TabIndex = 4;
            lbName.Text = "Họ và tên";
            // 
            // lbNumber
            // 
            lbNumber.Anchor = AnchorStyles.None;
            lbNumber.AutoSize = true;
            lbNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNumber.Location = new Point(177, 445);
            lbNumber.Name = "lbNumber";
            lbNumber.Size = new Size(29, 20);
            lbNumber.TabIndex = 5;
            lbNumber.Text = "Số";
            // 
            // lbBirthday
            // 
            lbBirthday.Anchor = AnchorStyles.None;
            lbBirthday.AutoSize = true;
            lbBirthday.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBirthday.Location = new Point(177, 475);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(78, 20);
            lbBirthday.TabIndex = 6;
            lbBirthday.Text = "Ngày sinh";
            // 
            // lbGender
            // 
            lbGender.Anchor = AnchorStyles.None;
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGender.Location = new Point(177, 505);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(67, 20);
            lbGender.TabIndex = 7;
            lbGender.Text = "Giới tính";
            // 
            // lbOrigin
            // 
            lbOrigin.Anchor = AnchorStyles.None;
            lbOrigin.AutoSize = true;
            lbOrigin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbOrigin.Location = new Point(177, 565);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(79, 20);
            lbOrigin.TabIndex = 8;
            lbOrigin.Text = "Quê quán";
            // 
            // lbNationality
            // 
            lbNationality.Anchor = AnchorStyles.None;
            lbNationality.AutoSize = true;
            lbNationality.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNationality.Location = new Point(177, 535);
            lbNationality.Name = "lbNationality";
            lbNationality.Size = new Size(76, 20);
            lbNationality.TabIndex = 9;
            lbNationality.Text = "Quốc tịch";
            // 
            // lbAddress
            // 
            lbAddress.Anchor = AnchorStyles.None;
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(177, 595);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(57, 20);
            lbAddress.TabIndex = 10;
            lbAddress.Text = "Địa chỉ";
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.None;
            tbName.Location = new Point(300, 415);
            tbName.Name = "tbName";
            tbName.Size = new Size(260, 23);
            tbName.TabIndex = 11;
            // 
            // tbNumber
            // 
            tbNumber.Anchor = AnchorStyles.None;
            tbNumber.Location = new Point(300, 445);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(260, 23);
            tbNumber.TabIndex = 12;
            // 
            // tbBirthday
            // 
            tbBirthday.Anchor = AnchorStyles.None;
            tbBirthday.Location = new Point(300, 475);
            tbBirthday.Name = "tbBirthday";
            tbBirthday.Size = new Size(260, 23);
            tbBirthday.TabIndex = 13;
            // 
            // tbGender
            // 
            tbGender.Anchor = AnchorStyles.None;
            tbGender.Location = new Point(300, 505);
            tbGender.Name = "tbGender";
            tbGender.Size = new Size(260, 23);
            tbGender.TabIndex = 14;
            // 
            // tbNationality
            // 
            tbNationality.Anchor = AnchorStyles.None;
            tbNationality.Location = new Point(300, 535);
            tbNationality.Name = "tbNationality";
            tbNationality.Size = new Size(260, 23);
            tbNationality.TabIndex = 15;
            // 
            // tbOrigin
            // 
            tbOrigin.Anchor = AnchorStyles.None;
            tbOrigin.Location = new Point(300, 565);
            tbOrigin.Name = "tbOrigin";
            tbOrigin.Size = new Size(260, 23);
            tbOrigin.TabIndex = 16;
            // 
            // tbAddress
            // 
            tbAddress.Anchor = AnchorStyles.None;
            tbAddress.Location = new Point(300, 595);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(260, 23);
            tbAddress.TabIndex = 17;
            // 
            // ptbFace
            // 
            ptbFace.Anchor = AnchorStyles.None;
            ptbFace.BackColor = SystemColors.ControlLightLight;
            ptbFace.Location = new Point(26, 400);
            ptbFace.Name = "ptbFace";
            ptbFace.Size = new Size(120, 160);
            ptbFace.SizeMode = PictureBoxSizeMode.Zoom;
            ptbFace.TabIndex = 18;
            ptbFace.TabStop = false;
            // 
            // lbExpired
            // 
            lbExpired.Anchor = AnchorStyles.None;
            lbExpired.AutoSize = true;
            lbExpired.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbExpired.Location = new Point(177, 625);
            lbExpired.Name = "lbExpired";
            lbExpired.Size = new Size(103, 20);
            lbExpired.TabIndex = 19;
            lbExpired.Text = "Ngày hết hạn";
            // 
            // tbExpired
            // 
            tbExpired.Anchor = AnchorStyles.None;
            tbExpired.Location = new Point(300, 625);
            tbExpired.Name = "tbExpired";
            tbExpired.Size = new Size(260, 23);
            tbExpired.TabIndex = 20;
            // 
            // ptbQR
            // 
            ptbQR.Anchor = AnchorStyles.None;
            ptbQR.BackColor = SystemColors.ControlLightLight;
            ptbQR.Location = new Point(54, 580);
            ptbQR.Name = "ptbQR";
            ptbQR.Size = new Size(64, 64);
            ptbQR.SizeMode = PictureBoxSizeMode.Zoom;
            ptbQR.TabIndex = 21;
            ptbQR.TabStop = false;
            // 
            // Detect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1008, 686);
            Controls.Add(ptbQR);
            Controls.Add(tbExpired);
            Controls.Add(lbExpired);
            Controls.Add(ptbFace);
            Controls.Add(tbAddress);
            Controls.Add(tbOrigin);
            Controls.Add(tbNationality);
            Controls.Add(tbGender);
            Controls.Add(tbBirthday);
            Controls.Add(tbNumber);
            Controls.Add(tbName);
            Controls.Add(lbAddress);
            Controls.Add(lbNationality);
            Controls.Add(lbOrigin);
            Controls.Add(lbGender);
            Controls.Add(lbBirthday);
            Controls.Add(lbNumber);
            Controls.Add(lbName);
            Controls.Add(ptbCropImage);
            Controls.Add(ptbDefaultImage);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Detect";
            Text = "Nhận diện và trích xuất thông tin căn cước công dân";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbDefaultImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbCropImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbFace).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openWebcamToolStripMenuItem;
        private ToolStripMenuItem openPictureToolStripMenuItem;
        private PictureBox ptbDefaultImage;
        private PictureBox ptbCropImage;
        private Label lbName;
        private Label lbNumber;
        private Label lbBirthday;
        private Label lbGender;
        private Label lbOrigin;
        private Label lbNationality;
        private Label lbAddress;
        private TextBox tbName;
        private TextBox tbNumber;
        private TextBox tbBirthday;
        private TextBox tbGender;
        private TextBox tbNationality;
        private TextBox tbOrigin;
        private TextBox tbAddress;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem cropToolStripMenuItem;
        private ToolStripMenuItem reconizeToolStripMenuItem;
        private ToolStripMenuItem takePhotoToolStripMenuItem;
        private PictureBox ptbFace;
        private Label lbExpired;
        private TextBox tbExpired;
        private PictureBox ptbQR;
    }
}