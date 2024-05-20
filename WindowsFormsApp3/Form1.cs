using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        static public string LoginActive;
        static public string whois;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBconnection.ConnectionDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Authorization.AuthorizationMethod(textBox1.Text, textBox2.Text);
                switch (Authorization.role)
                {
                    case null:
                        {
                            MessageBox.Show("Toks naudotojas neegzistuoja", "Patikrinkit ivestus duomenius", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                        }
                    case "Admin":
                        {
                            LoginActive = textBox1.Text;
                            whois = "Admin";
                            Authorization.User = textBox1.Text;
                            string surname = Authorization.AuthorizationName(textBox1.Text);
                            Authorization.surname = surname;
                            MessageBox.Show(surname + ", sveiki prisijungus i Administratoriaus menu", "Sekmingai!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            KlientoMenu admin = new KlientoMenu(surname);
                            admin.Show();
                            break;
                        }
                    case "Neigalus":
                        {
                            LoginActive = textBox1.Text;
                            whois = "Neigalus";
                            Authorization.User = textBox1.Text;
                            string surname = Authorization.AuthorizationName(textBox1.Text);
                            string sur = textBox2.Text;
                            Authorization.surname = surname;
                            sur = textBox2.Text;

                            KlientoMenu destytojas = new KlientoMenu(surname);

                            MessageBox.Show(surname + ", sveiki prisijungus i KA Kinoteatro menu!", "Sekmingai!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            destytojas.Show();
                            break;
                        }
                    case "Senjoras":
                        {
                            LoginActive = textBox1.Text;
                            whois = "Senjoras";
                            Authorization.User = textBox1.Text;
                            string surname = Authorization.AuthorizationName(textBox1.Text);
                            string sur = textBox2.Text;
                            Authorization.surname = surname;
                            sur = textBox2.Text;

                            KlientoMenu destytojas = new KlientoMenu(surname);

                            MessageBox.Show(surname + ", sveiki prisijungus i KA Kinoteatro menu!", "Sekmingai!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            destytojas.Show();
                            break;
                        }
                    case "Studentas":
                        {
                            LoginActive = textBox1.Text;
                            whois = "Studentas";
                            Authorization.User = textBox1.Text;
                            string surname = Authorization.AuthorizationName(textBox1.Text);
                            string sur = textBox2.Text;
                            Authorization.surname = surname;
                            sur = textBox2.Text;

                            KlientoMenu destytojas = new KlientoMenu(surname);

                            MessageBox.Show(surname + ", sveiki prisijungus i KA Kinoteatro menu!", "Sekmingai!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            destytojas.Show();
                            break;
                        }

                }

            }
            else
            {
                MessageBox.Show("Uzpildikyte visus ivedimo langus!", "Klaida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

