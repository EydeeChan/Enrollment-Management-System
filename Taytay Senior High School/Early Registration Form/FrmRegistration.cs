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
using MySql.Data.MySqlClient;
#endregion

namespace Early_Registration_Form
{
    public partial class FrmRegistration : Form
    {
        private MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private const int cs = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cs;
                return cp;
            }
        }
        private int Form = 0;
        #region Form Load
        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.ToString("yyyyMM");
            RetrieveSchoolYear();
            #region Fade In

            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity
            t1.Start();

            #endregion Fade In
            lblenrollmentid.Text = "Enrollment ID: " + currentYear;
            DateAndTime.Start();
            Form = 1;
            BtnBack.Visible = false;
            //Add module1 to panel control
            if (!panel4.Controls.Contains(Registration.RegistrationPart1.Instance))
            {
                panel4.Controls.Add(Registration.RegistrationPart1.Instance);
                Registration.RegistrationPart1.Instance.Dock = DockStyle.Fill;
                Registration.RegistrationPart1.Instance.BringToFront();
            }
            else
                Registration.RegistrationPart1.Instance.BringToFront();
        }
        #endregion
        #region Fade In Event

        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }

        #endregion Fade In Event
        #region Next Button
        private void BtnNext_Click(object sender, EventArgs e)
        {
            Form++;
            BtnBack.Visible = true;
            if (Form == 2)
            {
                //Add module2 to panel control
                if (!panel4.Controls.Contains(Registration.RegistrationPart2.Instance))
                {
                    panel4.Controls.Add(Registration.RegistrationPart2.Instance);
                    Registration.RegistrationPart2.Instance.Dock = DockStyle.Fill;
                    Registration.RegistrationPart2.Instance.BringToFront();
                    panel4.Controls.Clear();
                }
                else
                    Registration.RegistrationPart2.Instance.BringToFront();
            }
            else if (Form == 3)
            {
                BtnNext.Visible = false;
                //Add module3 to panel control
                if (!panel4.Controls.Contains(Registration.RegistrationPart3.Instance))
                {
                    panel4.Controls.Add(Registration.RegistrationPart3.Instance);
                    Registration.RegistrationPart3.Instance.Dock = DockStyle.Fill;
                    Registration.RegistrationPart3.Instance.BringToFront();
                }
                else
                    Registration.RegistrationPart3.Instance.BringToFront();
            }
        }
        #endregion
        #region Back Button
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form--;
            BtnNext.Visible = true;
            if (Form == 1)
            {
                BtnBack.Visible = false;
                //Add module2 to panel control
                if (!panel4.Controls.Contains(Registration.RegistrationPart1.Instance))
                {
                    panel4.Controls.Add(Registration.RegistrationPart1.Instance);
                    Registration.RegistrationPart1.Instance.Dock = DockStyle.Fill;
                    Registration.RegistrationPart1.Instance.BringToFront();
                }
                else
                    Registration.RegistrationPart1.Instance.BringToFront();
            }
            else if (Form == 2)
            {
                //Add module3 to panel control
                if (!panel4.Controls.Contains(Registration.RegistrationPart2.Instance))
                {
                    panel4.Controls.Add(Registration.RegistrationPart2.Instance);
                    Registration.RegistrationPart2.Instance.Dock = DockStyle.Fill;
                    Registration.RegistrationPart2.Instance.BringToFront();
                }
                else
                    Registration.RegistrationPart2.Instance.BringToFront();
            }
        }
        #endregion
        #region Date and Time Tick
        private void DateAndTime_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dddd  MMMM dd yyyy");
            label5.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        #endregion
        #region Retrieved School Year
        public void RetrieveSchoolYear()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
                con.Open();
                String query = "select school_year from school_year where status = 'Current Year'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    GlobalVar.SchoolYear = (dr["school_year"]).ToString();
                    label4.Text = "SY: " + GlobalVar.SchoolYear;
                }
                dr.Close();
                con.Close();
            }
            catch
            {
            }
        }
        #endregion
        #region Close Button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Minimized Button
        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
