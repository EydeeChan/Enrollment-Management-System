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

namespace Enrollment_Management_System
{
    public partial class FrmDashboard : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmDashboard()
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
        #region Logout Button
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LogHistoryLogoutSuccess(GlobalVar.user_id, GlobalVar.user_type, GlobalVar.username);
        }
        #endregion
        #region Log History Logout Success
        private void LogHistoryLogoutSuccess(string user_id, string user_type, string user)
        {
            try
            {
                con.Open();
                //Query to log history
                string query3 = "INSERT INTO `loghistory`(`account_id`, `account_type`,`username`, `log`) VALUES (@id, @accid,@user, @logs)";
                MySqlCommand cmd3 = new MySqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("@id", user_id);
                cmd3.Parameters.AddWithValue("@accid", user_type);
                cmd3.Parameters.AddWithValue("@user", user);
                cmd3.Parameters.AddWithValue("@logs", user + " has been succesfully logout.");
                cmd3.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                Notification.NotificationConnectionError a = new Notification.NotificationConnectionError();
                a.ShowDialog();
            }
        }
        #endregion
        #region Form Load
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
        }
        #endregion
        #region Fade In Event
        void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        #endregion
        #region Dashboard Button
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.Dashboard a = new Admin_Form.Dashboard();
            panel4.Controls.Add(a);
            a.Show();
            GC.Collect();
        }
        #endregion
        #region Enrollment Button
        private void BtnEnrollment_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.Enrollment.Enrollment a = new Admin_Form.Enrollment.Enrollment();
            panel4.Controls.Add(a);
            a.Show();
        }
        #endregion
        #region Enrollment History Button
        private void BtnEnrollmentHistory_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.EnrollmentHistory.EnrollmentHistory a = new Admin_Form.EnrollmentHistory.EnrollmentHistory();
            panel4.Controls.Add(a);
            a.Show();
        }
        #endregion
        #region Student Masterlist Button
        private void BtnStudentMasterList_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.StudentMasterList.StudentMasterlist a = new Admin_Form.StudentMasterList.StudentMasterlist();
            panel4.Controls.Add(a);
            a.Show();
        }
        #endregion
        #region Requirement Checklist Button
        private void BtnRequirementChecklist_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.RequirementChecklist a = new Admin_Form.RequirementChecklist();
            panel4.Controls.Add(a);
            a.Show();
        }
        #endregion
        #region Scheduler Button
        private void BtnScheduler_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.Scheduler.Scheduler a = new Admin_Form.Scheduler.Scheduler();
            panel4.Controls.Add(a);
            a.Show();
        }
        #endregion
        #region Classlist Button
        private void BtnClasslist_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.ClassList.Classlist a = new Admin_Form.ClassList.Classlist();
            panel4.Controls.Add(a);
            a.Show();
        }
        #endregion
        #region Track and Strand Button
        private void BtnTrackandStrand_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.TrackandStrand a = new Admin_Form.TrackandStrand();
            panel4.Controls.Add(a);
            a.Show();
            GC.Collect();
        }
        #endregion
        #region Section Button 
        private void BtnSection_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.Section a = new Admin_Form.Section();
            panel4.Controls.Add(a);
            a.Show();
            GC.Collect();
        }
        #endregion
        #region Subject Button
        private void BtnSubjects_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.Subjects a = new Admin_Form.Subjects();
            panel4.Controls.Add(a);
            a.Show();
            GC.Collect();

        }
        #endregion
        #region Teacher Masterlist Button
        private void BtnTeacherMasterlist_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.TeacherMasterlist.TeacherMasterlist a = new Admin_Form.TeacherMasterlist.TeacherMasterlist();
            panel4.Controls.Add(a);
            a.Show();
            GC.Collect();
        }
        #endregion
        #region Staff Masterlist Button
        private void BtnStaffMasterlist_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.StaffMasterlist.StaffMasterlist a = new Admin_Form.StaffMasterlist.StaffMasterlist();
            panel4.Controls.Add(a);
            a.Show();
            GC.Collect();
        }
        #endregion
        #region Settings Button
        private void BtnSetting_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            Admin_Form.Settings.Settings a = new Admin_Form.Settings.Settings();
            panel4.Controls.Add(a);
            a.Show();
            GC.Collect();
        }
        #endregion
    }
}
