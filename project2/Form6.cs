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
    public partial class Form6 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Apply_Click(object sender, EventArgs e)
        {
            string Username = Username2.Text;
            string Password = Password2.Text;
            string Confirm = ConfirmPass.Text;
           
            if (NameText3.Text != "" && SurnameText3.Text != "" && Username2.Text != "" && Password2.Text != "" && ConfirmPass.Text != "" && Phonenumber.Text != "" && address.Text != "")
            {
                if (Password2.Text == ConfirmPass.Text)
                {

                    if (Phonenumber.TextLength < 10)
                    {
                        MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (Username.Length < 6 || Password.Length < 6 || Confirm.Length < 6)
                    {
                        MessageBox.Show("กรุณากรอก Username,Password,อย่างน้อย 6 ตัว");
                    }
                    else
                    {

                        MySqlConnection conn = databaseConnection();
                        String sql = "INSERT INTO login (Name, Surname,Address,Phonenumber,Username,Password) VALUES('" + NameText3.Text + "','" + SurnameText3.Text + "' ,'" +address.Text+"','"+ Phonenumber.Text + "','" + Username2.Text + "','" + Password2.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("สร้างบัญชีผู้ใช้สำเร็จ");
                            Form7 a = new Form7();
                            this.Hide();
                            a.Show();
                        }

                        NameText3.Clear();
                        SurnameText3.Clear();
                        Username2.Clear();
                        Password2.Clear();
                        address.Clear();

                    }
              
                }
                else
                {
                    MessageBox.Show("รหัสผ่านไม่ตรงกัน");
                }

            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
        }

          

       private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            this.Hide();
            a.Show();
        }

        private void Back3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void Username2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void Password2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void ConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void Phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาป้อนเฉพาะตัวเลขเท่านั้น");
                e.Handled = true;
            }
        }
    }
    
}
