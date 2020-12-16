using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment_Management_System
{
    class Connection
    {
        private static string Server = "";
        private static string Database = "";
        private static string Username = "";
        private static string Password = "";
        private static string Port = "";
        private static string Connstr = "";
        public static string GetConnectionStr()
        {
            return Connstr = "SERVER=" + Server + ";" + "DATABASE=" + Database + ";" + "UID=" + Username + ";" + "PASSWORD=" + Password + ";" + "PORT=" + Port + ";";
        }
        public static void SetServer(string Server)
        {
            Connection.Server = Server;
        }
        public static void SetDatabase(string Database)
        {
            Connection.Database = Database;
        }
        public static void SetUid(string Username)
        {
            Connection.Username = Username;
        }
        public static void SetPassword(string Password)
        {
            Connection.Password = Password;
        }
        public static void SetPort(string Port)
        {
            Connection.Port = Port;
        }
    }
}
