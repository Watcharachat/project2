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

namespace project2
{
    public partial class Form7 : Form
    {

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }



        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Login2_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM login WHERE Username = \"{Username3.Text}\" AND Password = \"{Password3.Text}\"";
            MySqlDataReader row = cmd.ExecuteReader();
            row.Read();
            if (row.HasRows)
            {
                Program.Name = row.GetString("Name");
                Program.Surname = row.GetString("Surname");
                Program.Phonenumber = row.GetString("Phonenumber");
                Program.Address = row.GetString("Address");
                MessageBox.Show("เข้าสู่ระบบสำเร็จ");
                Form3 a = new Form3();
                this.Hide();
                a.Show();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้ หรือ รหัสไม่ถูกต้อง");
            }
            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password3.PasswordChar = '\0';
            }
            else
            {
                Password3.PasswordChar = '•';
            }
        }

        private void Username3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void Password3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            this.Hide();
            a.Show();
        }
    }
}

