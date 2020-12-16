
namespace Enrollment_Management_System.Admin_Form.Enrollment
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TxtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.lblconnected = new System.Windows.Forms.Label();
            this.BtnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 587);
            this.dataGridView1.TabIndex = 255;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Active = false;
            this.BtnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.BorderRadius = 5;
            this.BtnLogin.ButtonText = "Enroll";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BtnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnLogin.Iconimage = null;
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
            this.BtnLogin.Location = new System.Drawing.Point(994, 31);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.BtnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BtnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnLogin.selected = false;
            this.BtnLogin.Size = new System.Drawing.Size(91, 27);
            this.BtnLogin.TabIndex = 254;
            this.BtnLogin.Text = "Enroll";
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.Textcolor = System.Drawing.Color.White;
            this.BtnLogin.TextFont = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Hint = "";
            this.TxtUsername.Location = new System.Drawing.Point(616, 35);
            this.TxtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.Size = new System.Drawing.Size(362, 23);
            this.TxtUsername.TabIndex = 253;
            this.TxtUsername.Text = "ENTER STUDENT NAME (PRESS ENTER TO SEARCH)";
            this.TxtUsername.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(396, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 252;
            this.label1.Text = "2020-2021";
            // 
            // lblconnected
            // 
            this.lblconnected.AutoSize = true;
            this.lblconnected.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconnected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblconnected.Location = new System.Drawing.Point(68, 34);
            this.lblconnected.Name = "lblconnected";
            this.lblconnected.Size = new System.Drawing.Size(322, 24);
            this.lblconnected.TabIndex = 251;
            this.lblconnected.Text = "Enrolled Studentlist School Year:";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.Location = new System.Drawing.Point(22, 18);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 40);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 250;
            this.BtnClose.TabStop = false;
            this.BtnClose.Zoom = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(170, 688);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 257;
            this.label3.Text = "200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(18, 688);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 256;
            this.label2.Text = "Record(s) Count:";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblconnected);
            this.Controls.Add(this.BtnClose);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1087, 707);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblconnected;
        private Bunifu.Framework.UI.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
