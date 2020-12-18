using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Early_Registration_Form.Prospectus
{
    public partial class Prospectus : UserControl
    {
        public Prospectus()
        {
            InitializeComponent();
        }
        #region Instance

        private static Prospectus _instance;

        public static Prospectus Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Prospectus();
                return _instance;
            }
        }

        #endregion Instance
    }
}
