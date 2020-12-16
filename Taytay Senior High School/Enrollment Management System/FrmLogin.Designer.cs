
namespace Enrollment_Management_System
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblconnected = new System.Windows.Forms.Label();
            this.lblnotconnected = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMinimized = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RememberMeCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CheckCon = new System.Windows.Forms.Timer(this.components);
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 519);
            this.panel1.TabIndex = 218;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.lblconnected);
            this.panel4.Controls.Add(this.lblnotconnected);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(0, 499);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 20);
            this.panel4.TabIndex = 242;
            // 
            // lblconnected
            // 
            this.lblconnected.AutoSize = true;
            this.lblconnected.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblconnected.Location = new System.Drawing.Point(1, 1);
            this.lblconnected.Name = "lblconnected";
            this.lblconnected.Size = new System.Drawing.Size(107, 21);
            this.lblconnected.TabIndex = 231;
            this.lblconnected.Text = "Connected";
            // 
            // lblnotconnected
            // 
            this.lblnotconnected.AutoSize = true;
            this.lblnotconnected.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotconnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblnotconnected.Location = new System.Drawing.Point(1, 1);
            this.lblnotconnected.Name = "lblnotconnected";
            this.lblnotconnected.Size = new System.Drawing.Size(143, 21);
            this.lblnotconnected.TabIndex = 230;
            this.lblnotconnected.Text = "Not Connected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 40);
            this.label3.TabIndex = 207;
            this.label3.Text = "Taytay Senior High School";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 23);
            this.label5.TabIndex = 208;
            this.label5.Text = "21 B. Pag-asa St. Brgy. Dolores Taytay, Rizal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 64);
            this.label4.TabIndex = 206;
            this.label4.Text = "Welcome to the \r\nTaySenHigh Enrollment Portal\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.BtnLogin);
            this.panel2.Controls.Add(this.BtnMinimized);
            this.panel2.Controls.Add(this.BtnClose);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.RememberMeCheckBox);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TxtPassword);
            this.panel2.Controls.Add(this.TxtUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(373, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 519);
            this.panel2.TabIndex = 220;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(0, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 20);
            this.panel3.TabIndex = 241;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Active = false;
            this.BtnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.BorderRadius = 5;
            this.BtnLogin.ButtonText = "LOGIN";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.Iconimage")));
            this.BtnLogin.Iconimage_right = null;
            this.BtnLogin.Iconimage_right_Selected = null;
            this.BtnLogin.Iconimage_Selected = null;
            this.BtnLogin.IconMarginLeft = 0;
            this.BtnLogin.IconMarginRight = 0;
            this.BtnLogin.IconRightVisible = true;
            this.BtnLogin.IconRightZoom = 0D;
            this.BtnLogin.IconVisible = true;
            this.BtnLogin.IconZoom = 50D;
            this.BtnLogin.IsTab = false;
            this.BtnLogin.Location = new System.Drawing.Point(62, 416);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnLogin.selected = false;
            this.BtnLogin.Size = new System.Drawing.Size(266, 36);
            this.BtnLogin.TabIndex = 240;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.Textcolor = System.Drawing.Color.White;
            this.BtnLogin.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnMinimized
            // 
            this.BtnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimized.Image")));
            this.BtnMinimized.ImageActive = null;
            this.BtnMinimized.Location = new System.Drawing.Point(291, 12);
            this.BtnMinimized.Name = "BtnMinimized";
            this.BtnMinimized.Size = new System.Drawing.Size(30, 30);
            this.BtnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimized.TabIndex = 238;
            this.BtnMinimized.TabStop = false;
            this.BtnMinimized.Zoom = 50;
            this.BtnMinimized.Click += new System.EventHandler(this.BtnMinimized_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(327, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 237;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 50;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 284);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 235;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 234;
            this.pictureBox2.TabStop = false;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.RememberMeCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.RememberMeCheckBox.Checked = false;
            this.RememberMeCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.RememberMeCheckBox.ForeColor = System.Drawing.Color.White;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(35, 330);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(20, 20);
            this.RememberMeCheckBox.TabIndex = 232;
            this.RememberMeCheckBox.OnChange += new System.EventHandler(this.RememberMeCheckBox_OnChange);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(58, 331);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 231;
            this.materialLabel1.Text = "Remember Me ?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(66, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 233;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(58, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 229;
            this.label1.Text = "Please fill in your basic info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 37);
            this.label2.TabIndex = 230;
            this.label2.Text = "Login";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "";
            this.TxtPassword.Location = new System.Drawing.Point(61, 291);
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(266, 23);
            this.TxtPassword.TabIndex = 228;
            this.TxtPassword.Text = "Password";
            this.TxtPassword.UseSystemPasswordChar = false;
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPass_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPass_Leave);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Hint = "";
            this.TxtUsername.Location = new System.Drawing.Point(61, 228);
            this.TxtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.Size = new System.Drawing.Size(266, 23);
            this.TxtUsername.TabIndex = 227;
            this.TxtUsername.Text = "Username";
            this.TxtUsername.UseSystemPasswordChar = false;
            this.TxtUsername.Enter += new System.EventHandler(this.TxtUser_Enter);
            this.TxtUsername.Leave += new System.EventHandler(this.TxtUser_Leave);
            // 
            // CheckCon
            // 
            this.CheckCon.Interval = 5000;
            this.CheckCon.Tick += new System.EventHandler(this.CheckCon_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLogin;
        private Bunifu.Framework.UI.BunifuImageButton BtnMinimized;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCheckbox RememberMeCheckBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsername;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblconnected;
        private System.Windows.Forms.Label lblnotconnected;
        private System.Windows.Forms.Timer CheckCon;
        private System.Windows.Forms.Timer t1;
    }
}