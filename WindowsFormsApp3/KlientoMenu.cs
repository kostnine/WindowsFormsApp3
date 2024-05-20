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
    public partial class KlientoMenu : Form
    {
        private string surname;
        public KlientoMenu(string surname)
        {
            InitializeComponent();
            this.surname = surname;
        }
        private string GetUserSurname()
        {
            return Authorization.surname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CheckAndUpdateLoyaltyStatus(string surname)
        {
            int currentStatus = GetCurrentLoyaltyStatus(surname);

            if (currentStatus == 1)
            {
                MessageBox.Show("Jus jau esate klubo narys.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Norite tapti klubo nariu?", "Patvirtinimas", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (SetLoyaltyStatus(surname, 1))
                    {
                        MessageBox.Show("Sekmingai!");
                    }
                    else
                    {
                        MessageBox.Show("Ivyko klaida.");
                    }
                }
            }
        }


        private int GetCurrentLoyaltyStatus(string surname)
        {
            try
            {


                // Очистка предыдущих параметров
                DBconnection.msCommand.Parameters.Clear();

                // Написание SQL запроса для получения статуса лояльности
                DBconnection.msCommand.CommandText = "SELECT Lojalumo_ID FROM klientas WHERE Pavarde = @Surname";
                DBconnection.msCommand.Parameters.AddWithValue("@Surname", surname);

                // Выполнение запроса
                object result = DBconnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);  // Предполагается, что Lojalumo_ID это целочисленное значение
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении статуса лояльности: " + ex.Message, "Ошибка Базы Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0; // Возвращаем 0, если статус не найден или произошла ошибка
        }


        private bool SetLoyaltyStatus(string surname, int status)
        {
            try
            {

                DBconnection.msCommand.Parameters.Clear();
                DBconnection.msCommand.CommandText = "UPDATE klientas SET Lojalumo_ID = @Status WHERE Pavarde = @Surname";
                DBconnection.msCommand.Parameters.AddWithValue("@Status", status);
                DBconnection.msCommand.Parameters.AddWithValue("@Surname", surname);

                int affectedRows = DBconnection.msCommand.ExecuteNonQuery();

                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                // Обработка возможной ошибки при выполнении SQL запроса
                MessageBox.Show("Ошибка при обновлении статуса лояльности: " + ex.Message, "Ошибка Базы Данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
            

        private void KlientoMenu_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
            dataGridView2.Visible = false;
            Filmai.GetFilmas();
            Filmai.GetStud();
            dataGridView1.DataSource = Filmai.dbFilmai;
            dataGridView2.DataSource = Filmai.dbSeansas;
            comboBox1.DataSource = Filmai.dbFilmai;
            comboBox1.DisplayMember = "Metai";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedKebulas = comboBox1.Text;


            // Apply the filter to the DataTable (assuming dbAuto is a DataTable)
            DataView dv = new DataView(Filmai.dbFilmai);
            dv.RowFilter = $"Metai = '{selectedKebulas}'";

            // Display the filtered results in dataGridView1
            dataGridView1.DataSource = dv.ToTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Getting data from the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string filmas = selectedRow.Cells["ID_Filmas"].Value.ToString();
                DataView dv1 = new DataView(Filmai.dbSeansas);
                dv1.RowFilter = $"ID_Filmas ='{filmas}'";
                dataGridView2.DataSource = dv1.ToTable();
                dataGridView2.Visible = true;
                dataGridView1.Visible = false;
                comboBox1.Visible = false;
                button1 .Visible = false;
                button2.Visible = false;
                button3 .Visible = false;
                button4.Visible = true;


            }
            else
            {
                MessageBox.Show("Pasirinkite Filma!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sekmingai nupirktas biletas!");
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            comboBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

               string surname = GetUserSurname(); // Метод для получения фамилии текущего пользователя
               CheckAndUpdateLoyaltyStatus(surname);


        }
    }
}
