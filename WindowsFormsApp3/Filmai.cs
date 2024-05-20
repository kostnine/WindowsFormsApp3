using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class Filmai:DBconnection
    {
        static public DataTable dbFilmai = new DataTable();
        static public DataTable dbSeansas = new DataTable();
        static public void GetFilmas()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT * FROM filmas";
                dbFilmai.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dbFilmai);
            }
            catch
            {
                MessageBox.Show("Klaida gaunat duomenius", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static public void GetStud()
        {
            try
            {
                DBconnection.msCommand.CommandText = "SELECT * FROM seansas";
                dbSeansas.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dbSeansas);
            }
            catch
            {
                MessageBox.Show("Klaida gaunat duomenius", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
