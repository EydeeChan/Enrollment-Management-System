﻿#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Enrollment_Management_System.Notification
{
    public partial class NotificationAddedSuccess : Form
    {
        public NotificationAddedSuccess()
        {
            InitializeComponent();
        }
        #region Okay Button
        private void BtnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }
        #endregion
    }
}
