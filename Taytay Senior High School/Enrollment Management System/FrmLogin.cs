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
    public partial class FrmLogin : Form
    {
        MySqlConnection con = new MySqlConnection(Connection.GetConnectionStr());
        public FrmLogin()
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
        #region Place Holder
        private void TxtUser_Enter(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Username")
            {
                TxtUsername.Text = "";
                TxtUsername.Clear();
                TxtUsername.ForeColor = Color.Black;
            }
        }
        private void TxtUser_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
            {
                TxtUsername.Clear();
                TxtUsername.Text = "Username";
                TxtUsername.ForeColor = Color.Silver;
            }
        }
        private void TxtPass_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.PasswordChar = '•';
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.Black;
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
        private void TxtPass_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.PasswordChar = '\0';
                TxtPassword.Text = "Password";
                TxtPassword.ForeColor = Color.Silver;
                TxtPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion
        #region Remember Me CheckBox Changed
        private void RememberMeCheckBox_OnChange(object sender, EventArgs e)
        {
            if (RememberMeCheckBox.Checked)
            {
                Properties.Settings.Default.Username = TxtUsername.Text;
                Properties.Settings.Default.Password = TxtPassword.Text;
                Properties.Settings.Default.Save();
            }
        }
        #endregion
        #region Login Button
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            GlobalVar.user = TxtUsername.Text;
            if (TxtUsername.Text == "Username" && TxtPassword.Text == "Password")
            {
                label10.Text = "Username and Password can't be blank!";
            }
            else if (TxtPassword.Text == "Password" && TxtUsername.Text == "")
            {
                label10.Text = "Username and Password can't be blank!";
            }
            else if (TxtUsername.Text == "Username" && TxtPassword.Text == "")
            {
                label10.Text = "Username and Password can't be blank!";
            }
            else if (TxtUsername.Text == "Username")
            {
                label10.Text = "Username can't be blank! ";
            }
            else if (TxtPassword.Text == "Password")
            {
                label10.Text = "Password can't be blank! ";
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "SELECT account_type, account_id, status FROM account WHERE username = @user and password = @pass";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", TxtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", SHA256Hasher.ComputeSha256Hash(TxtPassword.Text));
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        GlobalVar.user_type = reader["account_type"].ToString();
                        GlobalVar.user_id = reader["account_id"].ToString();
                        GlobalVar.status = reader["status"].ToString();
                        GlobalVar.username = reader["username"].ToString();
                    }
                    con.Close();
                    if (GlobalVar.user_type == "")
                    {
                        label10.Text = "Incorrect Password or Username. ";
                    }
                    else
                    {
                        if (GlobalVar.status.Equals("Activated"))
                        {
                            LogHistoryLoginSuccess(GlobalVar.user_id, GlobalVar.user_type, TxtUsername.Text);
                            if (GlobalVar.user_type.Equals("Admin"))
                            {
                                FrmDashboard a = new FrmDashboard();
                                a.Show();
                                this.Hide();
                            }
                            else
                            {
                                label10.Text = "Account is not activated.";
                            }
                        }
                    }
                }
                catch
                {
                    Notification.NotificationConnectionError a = new Notification.NotificationConnectionError();
                    a.ShowDialog();
                }
            }
        }
        #endregion
        #region Minimized Button
        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Close Button
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Log History Login Success
        private void LogHistoryLoginSuccess(string user_id, string user_type, string user)
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
                cmd3.Parameters.AddWithValue("@logs", user + " has been succesfully login.");
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
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region Fade In
            Opacity = 0;      //first the opacity is 0

            t1.Interval = 10;  //we'll increase the opacity every 10ms
            t1.Tick += new EventHandler(FadeIn);  //this calls the function that changes opacity 
            t1.Start();
            #endregion
            lblconnected.Visible = false;
            lblnotconnected.Visible = false;
            CheckCon.Start();
            TxtUsername.Text = Properties.Settings.Default.Username;
            TxtPassword.Text = Properties.Settings.Default.Password;
            if (TxtUsername.Text == "" || TxtPassword.Text == "")
            {
                TxtUsername.Text = "Username";
                TxtPassword.Text = "Password";
                TxtPassword.PasswordChar = '\0';
            }
            else if (TxtUsername.Text == "Username" || TxtPassword.Text == "Password")
            {
                TxtUsername.Text = "Username";
                TxtPassword.Text = "Password";
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '•';
            }
        }
        #endregion
        #region Check Connection Timer
        private void CheckCon_Tick(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                lblconnected.Visible = true;
                lblnotconnected.Visible = false;
                con.Close();
            }
            else
            {
                lblnotconnected.Visible = true;
                lblconnected.Visible = false;
            }
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
    }
}