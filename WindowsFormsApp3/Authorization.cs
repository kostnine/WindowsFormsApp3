using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class Authorization
    {
        static public string role, surname, User;

        static public string Password { get; set; }

        static public void AuthorizationMethod(string login, string password)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT Statuso_pav from statusas, klientas WHERE Vardas = '" + login + "' and Pavarde ='" + password + "'and klientas.Statuso_ID=statusas.Statuso_ID";
                object result = DBconnection.msCommand.ExecuteScalar();
                if (result != null)
                {
                    role = result.ToString();
                    User = login;
                    Password = password; // сохраняем пароль
                }
                else
                {
                    role = User = Password = null;
                    surname = null;
                }
            }
            catch
            {
                role = User = Password = null;
                MessageBox.Show("Klaida prisijungus");
            }
        }
        static public string AuthorizationName(string login)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT Pavarde FROM klientas WHERE Vardas = '" + login + "' ";
                object result = DBconnection.msCommand.ExecuteScalar();
                surname = result.ToString();
                return surname;
            }
            catch
            {
                return null;
            }
        }
    }
}


