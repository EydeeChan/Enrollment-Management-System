#region Imports
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

namespace Early_Registration_Form.Registration
{
    public partial class RegistrationStart : UserControl
    {
        public RegistrationStart()
        {
            InitializeComponent();
        }
        #region Instance

        private static RegistrationStart _instance;

        public static RegistrationStart Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrationStart();
                return _instance;
            }
        }

        #endregion Instance
        #region New Student Button
        private void BtnNewStudent_Click(object sender, EventArgs e)
        {
            GlobalVar.EnrollmentStatus = "New Student";
            lblstatus.Text = "New Student";
        }
        #endregion
        #region Transferee Button
        private void BtnTransferee_Click(object sender, EventArgs e)
        {
            GlobalVar.EnrollmentStatus = "Transferee";
            lblstatus.Text = "Transferee";
        }
        #endregion
    }
}
