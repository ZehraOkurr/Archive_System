namespace ProjeOdev
{
    partial class giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnGiris = new Button();
            ımageList1 = new ImageList(components);
            label2 = new Label();
            sifreTxt = new TextBox();
            adTxt = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnGiris2 = new Button();
            sifreTxt2 = new TextBox();
            adTxt2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Honeydew;
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(sifreTxt);
            groupBox1.Controls.Add(adTxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(34, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 346);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fakülte Sekreteri Girişi";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password_120207;
            pictureBox2.Location = new Point(6, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 35);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197__1_;
            pictureBox1.Location = new Point(6, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 32);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = SystemColors.ControlLight;
            btnGiris.ForeColor = SystemColors.ControlText;
            btnGiris.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiris.ImageIndex = 0;
            btnGiris.ImageList = ımageList1;
            btnGiris.Location = new Point(130, 227);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(90, 27);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.TextAlign = ContentAlignment.MiddleRight;
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "png-clipart-computer-icons-login-symbol-login-interface-miscellaneous-text.png");
            ımageList1.Images.SetKeyName(1, "login-user-name-1.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 140);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // sifreTxt
            // 
            sifreTxt.Location = new Point(44, 163);
            sifreTxt.Name = "sifreTxt";
            sifreTxt.PasswordChar = '*';
            sifreTxt.Size = new Size(176, 27);
            sifreTxt.TabIndex = 2;
            // 
            // adTxt
            // 
            adTxt.Location = new Point(44, 87);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(176, 27);
            adTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 69);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Honeydew;
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(btnGiris2);
            groupBox2.Controls.Add(sifreTxt2);
            groupBox2.Controls.Add(adTxt2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(387, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 346);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Girişi";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.account_avatar_face_man_people_profile_user_icon_123197__1_;
            pictureBox4.Location = new Point(6, 82);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(33, 32);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password_120207;
            pictureBox3.Location = new Point(6, 158);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 35);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // btnGiris2
            // 
            btnGiris2.ImageAlign = ContentAlignment.MiddleLeft;
            btnGiris2.ImageKey = "png-clipart-computer-icons-login-symbol-login-interface-miscellaneous-text.png";
            btnGiris2.ImageList = ımageList1;
            btnGiris2.Location = new Point(131, 227);
            btnGiris2.Name = "btnGiris2";
            btnGiris2.Size = new Size(90, 27);
            btnGiris2.TabIndex = 5;
            btnGiris2.Text = "Giriş Yap";
            btnGiris2.TextAlign = ContentAlignment.MiddleRight;
            btnGiris2.UseVisualStyleBackColor = true;
            btnGiris2.Click += btnGiris2_Click;
            // 
            // sifreTxt2
            // 
            sifreTxt2.Location = new Point(45, 163);
            sifreTxt2.Name = "sifreTxt2";
            sifreTxt2.PasswordChar = '*';
            sifreTxt2.Size = new Size(176, 27);
            sifreTxt2.TabIndex = 3;
            // 
            // adTxt2
            // 
            adTxt2.Location = new Point(45, 87);
            adTxt2.Name = "adTxt2";
            adTxt2.Size = new Size(176, 27);
            adTxt2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 140);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 1;
            label4.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 64);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Adı";
            // 
            // giris
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(715, 466);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bursa Uludağ Üniversitesi Arşiv Sistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGiris;
        private Label label2;
        private TextBox sifreTxt;
        private TextBox adTxt;
        private Label label1;
        private TextBox sifreTxt2;
        private TextBox adTxt2;
        private Label label4;
        private Label label3;
        private Button btnGiris2;
        private ImageList ımageList1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}