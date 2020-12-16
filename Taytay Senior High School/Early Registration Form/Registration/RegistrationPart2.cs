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
        #region TxtMotherLastName Text Changed
        private void TxtMotherLastname_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.MotherLastName = TxtMotherLastname.Text;
        }
        #endregion
        #region TxtMotherFirstname Text Changed
        private void TxtMotherFirstName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.MotherFirstName = TxtMotherFirstName.Text;
        }
        #endregion
        #region TxtMotherMiddleName Text Changed
        private void TxtMotherMiddleName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.MotherMiddleName = TxtMotherMiddleName.Text;
        }
        #endregion
        #region TxtFatherLastName Text Changed
        private void TxtFatherLastName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.FatherLastName = TxtFatherLastName.Text;
        }
        #endregion
        #region TxtFatherFirstName Text Changed
        private void TxtFatherFirstName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.FatherFirstName = TxtFatherFirstName.Text;
        }
        #endregion
        #region TxtFatherMiddleName Text Changed
        private void TxtFatherMiddleName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.FatherMiddleName = TxtFatherMiddleName.Text;
        }
        #endregion
        #region TxtGuardian LastName Text Changed
        private void TxtGuardianLastName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.GuardianLastName = TxtGuardianLastName.Text;
        }
        #endregion
        #region TxtGuardianFirstName Text Changed
        private void TxtGuardianFirstName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.GuardianFirstName = TxtGuardianFirstName.Text;
        }
        #endregion
        #region TxtGuardianMiddleName Text Changed
        private void TxtGuardianMiddleName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.GuardianMiddleName = TxtGuardianMiddleName.Text;
        }
        #endregion
        #region CmbLvl Selectted Index Changed
        private void CmbLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.Lvl = CmbLvl.Text;
        }
        #endregion
        #region TxtLastGrade Text Changed
        private void TxtLastGrade_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.LastGrade = TxtLastGrade.Text;
        }
        #endregion
        #region TxtLastSchooolYear Text Changed
        private void TxtLastSchoolYear_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.LastSchoolYear = TxtLastSchoolYear.Text;
        }
        #endregion
        #region TxtSchoolName Text Changed
        private void TxtSchoolName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.SchoolName = TxtSchoolName.Text;
        }
        #endregion
        #region TxtSchoolIDTextChanged
        private void TxtSchoolID_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.SchoolID = TxtSchoolID.Text;
        }
        #endregion
        #region TxtSchoolAddress Text Changed
        private void TxtSchoolAddress_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.SchoolAddress = TxtSchoolAddress.Text;
        }
        #endregion
        #region Form Load

        private void RegistrationPart2_Load(object sender, EventArgs e)
        {
            TxtMotherFirstName.Text = GlobalVar.MotherFirstName;
            TxtMotherMiddleName.Text = GlobalVar.MotherMiddleName;
            TxtMotherLastname.Text = GlobalVar.MotherLastName;
            TxtFatherFirstName.Text = GlobalVar.FatherFirstName;
            TxtFatherMiddleName.Text = GlobalVar.FatherMiddleName;
            TxtFatherLastName.Text = GlobalVar.FatherLastName;
            TxtGuardianFirstName.Text = GlobalVar.GuardianFirstName;
            TxtGuardianMiddleName.Text = GlobalVar.GuardianMiddleName;
            TxtGuardianLastName.Text = GlobalVar.GuardianLastName;
            TxtSchoolID.Text = GlobalVar.SchoolID;
            TxtSchoolName.Text = GlobalVar.SchoolName;
            CmbLvl.Text = GlobalVar.Lvl;
            TxtSchoolAddress.Text = GlobalVar.SchoolAddress;
            TxtLastGrade.Text = GlobalVar.LastGrade;
            TxtLastSchoolYear.Text = GlobalVar.LastSchoolYear;
        }

        #endregion Form Load
    }
}
