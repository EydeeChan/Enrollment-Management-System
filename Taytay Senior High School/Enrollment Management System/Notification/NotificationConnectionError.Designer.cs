﻿
namespace Enrollment_Management_System.Notification
{
    partial class NotificationConnectionError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationConnectionError));
            this.BtnOkay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOkay
            // 
            this.BtnOkay.Active = false;
            this.BtnOkay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.BtnOkay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOkay.BorderRadius = 0;
            this.BtnOkay.ButtonText = "Okay";
            this.BtnOkay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOkay.DisabledColor = System.Drawing.Color.Gray;
            this.BtnOkay.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnOkay.Iconimage = null;
            this.BtnOkay.Iconimage_right = null;
            this.BtnOkay.Iconimage_right_Selected = null;
            this.BtnOkay.Iconimage_Selected = null;
            this.BtnOkay.IconMarginLeft = 0;
            this.BtnOkay.IconMarginRight = 0;
            this.BtnOkay.IconRightVisible = true;
            this.BtnOkay.IconRightZoom = 0D;
            this.BtnOkay.IconVisible = true;
            this.BtnOkay.IconZoom = 90D;
            this.BtnOkay.IsTab = false;
            this.BtnOkay.Location = new System.Drawing.Point(240, 93);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.BtnOkay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.BtnOkay.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnOkay.selected = false;
            this.BtnOkay.Size = new System.Drawing.Size(113, 27);
            this.BtnOkay.TabIndex = 36;
            this.BtnOkay.Text = "Okay";
            this.BtnOkay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnOkay.Textcolor = System.Drawing.Color.White;
            this.BtnOkay.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(96, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "EnrollmentManagement System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(96, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 126);
            this.label7.TabIndex = 37;
            this.label7.Text = "Connection Error. \r\nPlease contact the administrator.";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(365, 5);
            this.panel4.TabIndex = 33;
            // 
            // NotificationConnectionError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 132);
            this.Controls.Add(this.BtnOkay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationConnectionError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationConnectionError";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BtnOkay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
    }
}