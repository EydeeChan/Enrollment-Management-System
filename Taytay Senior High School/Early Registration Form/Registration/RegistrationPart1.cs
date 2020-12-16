#region Imports
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Early_Registration_Form.Registration
{
    public partial class RegistrationPart1 : UserControl
    {
        public RegistrationPart1()
        {
            InitializeComponent();
        }
        #region Instance

        private static RegistrationPart1 _instance;

        public static RegistrationPart1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RegistrationPart1();
                return _instance;
            }
        }

        #endregion Instance
        #region TxtLRN Text Changed 
        private void TxtLRN_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.LRN = TxtLRN.Text;
        }
        #endregion
        #region TxtPSA Text Changed
        private void TxtPSA_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.PSA = TxtPSA.Text;
        }
        #endregion
        #region TxtLastName Text Changed
        private void TxtLastName_TextAlignChanged(object sender, EventArgs e)
        {
            GlobalVar.LastName = TxtLastName.Text;
        }
        #endregion
        #region TxtFirstName Text Changed
        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.FirstName = TxtFirstName.Text;
        }
        #endregion
        #region TxtMiddle Text Changed
        private void TxtMiddleName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.MiddleName = TxtMiddleName.Text;
        }
        #endregion
        #region TxtExtension Text Changed
        private void TxtExtensionName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.ExtensionName = TxtExtensionName.Text;
        }
        #endregion
        #region TxtHouseStreet Text Changed
        private void TxtHouseStreet_TextAlignChanged(object sender, EventArgs e)
        {
            GlobalVar.HouseStreet = TxtHouseStreet.Text;
        }
        #endregion
        #region TxtBarangay Text Changed
        private void TxtBarangay_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.Barangay = TxtBarangay.Text;
        }
        #endregion
        #region TxtMunicipality Text Changed
        private void TxtMunicipality_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.Municipality = TxtMunicipality.Text;
        }
        #endregion
        #region TxtPronvince Text Changed
        private void TxtProvince_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.Province = TxtProvince.Text;
        }
        #endregion
        #region TxtZipCode Text Changed
        private void TxtZipCode_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.ZipCode = TxtZipCode.Text;
        }
        #endregion
        #region TxtEmail Text Changed
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.Email = TxtEmail.Text;
        }
        #endregion
        #region TxtMobile Text Changed
        private void TxtMobile_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.CellPhone = TxtMobile.Text;
        }
        #endregion
        #region TxtBirthPlace Text Changed
        private void TxtBirthPlace_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.BirthPlace = TxtBirthPlace.Text;
        }
        #endregion
        #region TxtReligion Text Changed 
        private void TxtReligion_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.Religion = TxtReligion.Text;
        }
        #endregion
        #region TxtEtnic TextChanged
        private void TxtEtnicGroup_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.EtnicGroup = TxtEtnicGroup.Text;
        }
        #endregion
        #region TxtMotherTounge Text Changed
        private void TxtMotherTounge_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.MotherTounge = TxtMotherTounge.Text;
        }
        #endregion
        #region Form Load
        private void RegistrationPart1_Load(object sender, EventArgs e)
        {
            TxtLRN.Text = GlobalVar.LRN;
            TxtPSA.Text = GlobalVar.PSA;
            TxtLastName.Text = GlobalVar.LastName;
            TxtFirstName.Text = GlobalVar.FirstName;
            TxtMiddleName.Text = GlobalVar.MiddleName;
            TxtExtensionName.Text = GlobalVar.ExtensionName;
            TxtEmail.Text = GlobalVar.Email;
            TxtHouseStreet.Text = GlobalVar.HouseStreet;
            TxtBarangay.Text = GlobalVar.Barangay;
            TxtMunicipality.Text = GlobalVar.Municipality;
            TxtProvince.Text = GlobalVar.Province;
            TxtBirthPlace.Text = GlobalVar.BirthPlace;
            TxtReligion.Text = GlobalVar.Religion;
            TxtMotherTounge.Text = GlobalVar.MotherTounge;
            TxtEtnicGroup.Text = GlobalVar.EtnicGroup;
            TxtZipCode.Text = GlobalVar.ZipCode;
            CmbSex.Text = GlobalVar.Sex;
            if (!string.IsNullOrEmpty(GlobalVar.BirthDate))
            {
                TxtBirthdate.Value = DateTime.ParseExact(GlobalVar.BirthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            TxtExtensionName.Text = GlobalVar.ExtensionName;
        }

        #endregion Form Load
        #region TxtBirthdate on Value Changed
        private void TxtBirthdate_onValueChanged(object sender, EventArgs e)
        {
            DateTime From = TxtBirthdate.Value;
            DateTime To = DateTime.Now;
            TimeSpan TSpan = To - From;
            Double Days = TSpan.TotalDays;
            groupBox4.Text = "Your Age : " + (Days / 365).ToString("0");
            GlobalVar.Age = (Days / 365).ToString("0");
            GlobalVar.BirthDate = TxtBirthdate.Value.ToString("dd/MM/yyyy");
            GlobalVar.Date = To.ToString("dd / MM / yyyy");
            GlobalVar.BirthYear = TxtBirthdate.Value.ToString("dd / MM / yyyy");
        }
        #endregion
        #region RadioWithLRN Checked Changed
        private void RadioWithLRN_CheckedChanged(object sender, EventArgs e)
        {
            TxtLRN.Enabled = true;
            GlobalVar.Checked = "LRN";
        }
        #endregion
        #region RadioBalikAral Checked Changed
        private void RadioBalikAral_CheckedChanged(object sender, EventArgs e)
        {
            TxtLRN.Enabled = true;
            GlobalVar.Checked = "BalikAral";
        }
        #endregion
        #region RadioNOLRN Checked Changed
        private void RadioNoLRN_CheckedChanged(object sender, EventArgs e)
        {
            TxtLRN.Enabled = false;
            GlobalVar.Checked = "NoLRN";
            TxtLRN.Text = "";
        }
        #endregion
        #region ComboSex Selected Index Changed
        private void CmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVar.Sex = CmbSex.Text;
        }
        #endregion
    }
}
