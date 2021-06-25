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
using System.Threading;
using System.Globalization;

namespace project2
{
    public partial class Form3 : Form

    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form3()
        {
            InitializeComponent();
            NameText2.Text = Program.Name;
            SurnameText2.Text = Program.Surname;
            Phonenumber2.Text = Program.Phonenumber;
            AddressText2.Text = Program.Address;

        }



        private void Form3_Load(object sender, EventArgs e)
        {
            DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
            this.birthday.CustomFormat = " ";
            this.birthday.Format = DateTimePickerFormat.Custom;
            loaddata001();
            foreach (var i in allbook)
            {
                comboBox1.Items.Add(i.Team);
            }
        }

        private void Asanateam_Click(object sender, EventArgs e)
        {
            if (NameText2.Text != "" && SurnameText2.Text != "" &&  AgeText2.Text != "" && AddressText2.Text != "" && height.Text != "" && weight.Text != "" && dominantfoot.Text != "" && standing.Text != "" && Phonenumber2.Text != "")
            {

                if (Phonenumber2.TextLength < 10)
                {
                    MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlConnection conn = databaseConnection();
                    String sql = "INSERT INTO player(Name,Surname,Birthday,Age,Address,Height,Weight,Dominant_Foot,Standing,Phonenumber,Team) VALUES('" + NameText2.Text + "','" + SurnameText2.Text + "','" + birthday.Value.ToString("dd/MM/yyyy") + "','"+ AgeText2.Text + "','" + AddressText2.Text + "','" + height.Text + "','" + weight.Text + "','" + dominantfoot.Text + "','" + standing.Text + "','" + Phonenumber2.Text + "','" + comboBox1.Text+"')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                        Form5 a = new Form5();
                        this.Hide();
                        a.Show();
                    }
                }

            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");

            }
            


        }

        private void AgeText2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาป้อนเฉพาะตัวเลขเท่านั้น");
                e.Handled = true;
            }
        }

        private void Phonenumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาป้อนเฉพาะตัวเลขเท่านั้น");
                e.Handled = true;
            }
        }

        private string calulateAge(string dateDOB)
        {
            int now = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            int dob = int.Parse(dateDOB);
            string dif = (now - dob).ToString();
            string age001 = "0";
            if (dif.Length > 4)
                age001 = dif.Substring(0, dif.Length - 4);
            return age001;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            AgeText2.Text = calulateAge(birthday.Value.ToString("yyyyMMdd"));
        }

        private void birthday_DropDown(object sender, EventArgs e)
        {
            DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
            this.birthday.CustomFormat = "dd MMM yyyy";
            this.birthday.Format = DateTimePickerFormat.Custom;
        }

        private List<Class1> allbook = new List<Class1>();
        private void loaddata001()
        {

            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project;");

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM team ", conn);
            MySqlDataReader adapter = cmd.ExecuteReader();
            while (adapter.Read())
            {
                Program.Team = adapter.GetString("Team");

                Class1 item = new Class1()
                {
                    Team = Program.Team,

                };
                allbook.Add(item);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            this.Hide();
            a.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skip_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            this.Hide();
            a.Show();
        }
    }

}
        


