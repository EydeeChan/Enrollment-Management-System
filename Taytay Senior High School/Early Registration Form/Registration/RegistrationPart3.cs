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
using MySql.Data.MySqlClient;
#endregion

namespace Early_Registration_Form.Registration
{
    public partial class RegistrationPart3 : UserControl
    {
        public RegistrationPart3()
        {
            InitializeComponent();
        }
        #region Instance

        private static RegistrationPart3 _instance;

        public static RegistrationPart3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrationPart3();
                return _instance;
            }
        }

        #endregion Instance
    }
}
