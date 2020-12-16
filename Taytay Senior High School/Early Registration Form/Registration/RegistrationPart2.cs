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
    public partial class RegistrationPart2 : UserControl
    {
        public RegistrationPart2()
        {
            InitializeComponent();
        }
        #region Instance

        private static RegistrationPart2 _instance;

        public static RegistrationPart2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrationPart2();
                return _instance;
            }
        }

        #endregion Instance
    }
}
