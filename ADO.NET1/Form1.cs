using System;
using System.Windows.Forms;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADO.NET1
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            sqlConnection.Open();

            /*
            if(sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение прошло успешно!");
                //sqlConnection.Close();
            }
            */
        }

        private void INSERT_Buttom_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [Student1] (Name, Age, Phone, vbnvng) " +
                    $"VALUES (N'{Name_textBox.Text}', {Int32.Parse(Age_textBox.Text)}, N'{Phone_textBox.Text}', N'{vbnvng_textBox.Text}')",
                    sqlConnection);

                

                MessageBox.Show($"найс... {command.ExecuteNonQuery().ToString()}");
            }
            catch (Exception ex) { 
                MessageBox.Show("ВСЕ ПОШЛО ПО ПИЗДЕ!\n", ex.Message);
                //sqlConnection.Close();
            }
        }

        private void Clear_buttom_Click(object sender, EventArgs e)
        {
            Name_textBox.Text = "";
            Age_textBox.Text = "";
            Phone_textBox.Text = "";
            vbnvng_textBox.Text = "";
        }

        private void SELECT_buttom_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(
                    textBox1.Text,
                    sqlConnection
                );

                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ДОЛБАЕБ ТЫ КАК ЗАПРОСЫ ПИШЕШЬ\n", ex.Message);
            }

        }
    }
}
