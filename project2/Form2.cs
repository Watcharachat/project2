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
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            showApplicants2();
            DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
            this.birthday.CustomFormat = " ";
            this.birthday.Format = DateTimePickerFormat.Custom;
            loaddata001();
            foreach (var i in allbook)
            {
                comboBox1.Items.Add(i.Team);
                team2.Items.Add(i.Team);

            }
        }




        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void AgeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาป้อนเฉพาะตัวเลขเท่านั้น");
                e.Handled = true;
            }

        }

        private void PhonenumberText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                MessageBox.Show("กรุณาป้อนเฉพาะตัวเลขเท่านั้น");
                e.Handled = true;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int selectedRow = dataApplicants2.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataApplicants2.Rows[selectedRow].Cells["id"].Value);
            if (NameText.Text != "" && SurnameText.Text != "" && AgeText.Text != "" && AddressText.Text != "" && height2.Text != "" && weight2.Text != "" && dominantfoot2.Text != "" && standing2.Text != "" && PhonenumberText.Text != "")
            {
                if (PhonenumberText.TextLength < 10)
                {
                    MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlConnection conn = databaseConnection();

                    string sql = "UPDATE player SET Name = '" + NameText.Text + "',Surname = '" + SurnameText.Text + "',Birthday ='" + birthday.Value.ToString("dd/MM/yyyy")+"', Age ='" + AgeText.Text + "',Address = '" + AddressText.Text + "',Height= '" + height2.Text + "' ,Weight='" + weight2.Text + "', Dominant_Foot='" + dominantfoot2.Text + "' , Standing='" + standing2.Text + "', Phonenumber ='" + PhonenumberText.Text + "',Team='"+team2.Text+"' WHERE id = '" + editId + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        showApplicants2();
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                        NameText.Clear();
                        SurnameText.Clear();
                        AgeText.Clear();
                        AddressText.Clear();
                        PhonenumberText.Clear();
                        height2.Clear();
                        weight2.Clear();
                        dominantfoot2.Clear();
                        standing2.Clear();
                        team2.Text = " ";
                        DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
                        this.birthday.CustomFormat = " ";
                        this.birthday.Format = DateTimePickerFormat.Custom;


                    }
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }

        }

        private void Delet_Click(object sender, EventArgs e)
        {
            int selectedRow = dataApplicants2.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataApplicants2.Rows[selectedRow].Cells["id"].Value);

            {

                MySqlConnection conn = databaseConnection();

                String sql = "DELETE FROM player WHERE id = '" + deleteId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();
                if (rows > 0)
                {
                    showApplicants2();
                    MessageBox.Show("ลบข้อมูลสำเร็จ");
                    NameText.Clear();
                    SurnameText.Clear();
                    AgeText.Clear();
                    AddressText.Clear();
                    PhonenumberText.Clear();
                    height2.Clear();
                    weight2.Clear();
                    dominantfoot2.Clear();
                    standing2.Clear();
                    team2.Text = " ";
                    DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
                    this.birthday.CustomFormat = " ";
                    this.birthday.Format = DateTimePickerFormat.Custom;



                }
            }

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            NameText.Clear();
            SurnameText.Clear();
            AgeText.Clear();
            AddressText.Clear();
            PhonenumberText.Clear();
            height2.Clear();
            weight2.Clear();
            dominantfoot2.Clear();
            standing2.Clear();
            team2.Text = " ";
            DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
            this.birthday.CustomFormat = " ";
            this.birthday.Format = DateTimePickerFormat.Custom;



        }

        private void showApplicants2()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM player ";


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataApplicants2.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
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
            DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
            this.birthday.CustomFormat = "dd MMM yyyy";
            this.birthday.Format = DateTimePickerFormat.Custom;
            AgeText.Text = calulateAge(birthday.Value.ToString("yyyyMMdd"));
        }


        private void Back_Click(object sender, EventArgs e)
        {

            Form1 a = new Form1();
            this.Hide();
            a.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            string team = comboBox1.Text;
            cmd.CommandText = $"SELECT * FROM player WHERE  Team=\"{team}\" ";


            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataApplicants2.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataApplicants2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataApplicants2.CurrentRow.Selected = true;
            NameText.Text = dataApplicants2.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            SurnameText.Text = dataApplicants2.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
            AgeText.Text = dataApplicants2.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
            AddressText.Text = dataApplicants2.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
            height2.Text = dataApplicants2.Rows[e.RowIndex].Cells["Height"].FormattedValue.ToString();
            weight2.Text = dataApplicants2.Rows[e.RowIndex].Cells["Weight"].FormattedValue.ToString();
            dominantfoot2.Text = dataApplicants2.Rows[e.RowIndex].Cells["Dominant_Foot"].FormattedValue.ToString();
            standing2.Text = dataApplicants2.Rows[e.RowIndex].Cells["Standing"].FormattedValue.ToString();
            PhonenumberText.Text = dataApplicants2.Rows[e.RowIndex].Cells["Phonenumber"].FormattedValue.ToString();
            team2.Text = dataApplicants2.Rows[e.RowIndex].Cells["Team"].FormattedValue.ToString();
            birthday.Text = dataApplicants2.Rows[e.RowIndex].Cells["Birthday"].FormattedValue.ToString();

        }

        private void asana3_Click(object sender, EventArgs e)
        {
            if (NameText.Text != "" && SurnameText.Text != "" && AgeText.Text != "" && AddressText.Text != "" && height2.Text != "" && weight2.Text != "" && dominantfoot2.Text != "" && standing2.Text != "" && PhonenumberText.Text != "")
            {

                if (PhonenumberText.TextLength < 10)
                {
                    MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์ให้ถูกต้อง", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlConnection conn = databaseConnection();
                    String sql = "INSERT INTO player(Name, Surname,Birthday,Age, Address,Height,Weight,Dominant_Foot,Standing, Phonenumber,Team) VALUES('" + NameText.Text + "','" + SurnameText.Text + "','" +birthday.Value.ToString("dd/MM/yyyy")+"','"  + AgeText.Text + "','" + AddressText.Text + "','" + height2.Text + "','" + weight2.Text + "','" + dominantfoot2.Text + "','" + standing2.Text + "','" + PhonenumberText.Text + "','" +team2.Text+"')";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        showApplicants2();
                        MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                        NameText.Clear();
                        SurnameText.Clear();
                        AgeText.Clear();
                        AddressText.Clear();
                        PhonenumberText.Clear();
                        height2.Clear();
                        weight2.Clear();
                        dominantfoot2.Clear();
                        standing2.Clear();
                        team2.Text = " ";
                        DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
                        this.birthday.CustomFormat = " ";
                        this.birthday.Format = DateTimePickerFormat.Custom;


                    }
                }

            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");

            }


        }

        private void competition_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            this.Hide();
            a.Show();
        }

        private void team_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            this.Hide();
            a.Show();
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

        private void birthday_DropDown(object sender, EventArgs e)
        {
            DateTimeFormatInfo dt = Thread.CurrentThread.CurrentCulture.DateTimeFormat;
            this.birthday.CustomFormat = "dd MMM yyyy";
            this.birthday.Format = DateTimePickerFormat.Custom;
        }







        private List<Class2> allbook2 = new List<Class2>();
        private void print_Click_1(object sender, EventArgs e)
        {
            allbook2.Clear();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            e.Graphics.DrawString("สโมสรฟุตบอล ASANA FOOTBALL CLUB", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(260, 140));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 160));
            e.Graphics.DrawString("รายการข้อมูลผู้สมัครเข้าร่วมการแข่งขัน", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 192));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 215));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 240));
            e.Graphics.DrawString("Name", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 255));
            e.Graphics.DrawString("Surname", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(200, 255));
            e.Graphics.DrawString("Birthday", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(370, 255));
            e.Graphics.DrawString("Age", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(500, 255));
            e.Graphics.DrawString("Standing", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(580, 255));
            e.Graphics.DrawString("Team", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(700, 255));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 265));
            int y = 290;
            loaddata();
            foreach (var i in allbook2)
            {
                e.Graphics.DrawString(i.Name, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(50, y));
                e.Graphics.DrawString(i.Surname, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(210, y));
                e.Graphics.DrawString(i.Birthday, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(365, y));
                e.Graphics.DrawString(i.Age, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(500, y));
                e.Graphics.DrawString(i.Standing, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(580, y));
                e.Graphics.DrawString(i.Team, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(705, y));
                y = y + 20;


                


            }
        }

        private void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project;");

            conn.Open();

            string Team = comboBox1.Text;
            if (Team == "")
            {

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM player ", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.Name = adapter.GetString("Name");
                    Program.Surname = adapter.GetString("Surname");
                    Program.Birthday = adapter.GetString("Birthday");
                    Program.Age = adapter.GetString("Age");
                    Program.Standing = adapter.GetString("Standing");
                    Program.Team = adapter.GetString("Team");
                    
                    Class2 item = new Class2()
                    {
                        Name = Program.Name,
                        Surname = Program.Surname,
                        Birthday = Program.Birthday,
                        Age = Program.Age,
                        Standing = Program.Standing,
                        Team = Program.Team,
                    };
                    allbook2.Add(item);
                }
                
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM player WHERE Team=\"{Team}\" ", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.Name = adapter.GetString("Name");
                    Program.Surname = adapter.GetString("Surname");
                    Program.Birthday = adapter.GetString("Birthday");
                    Program.Age = adapter.GetString("Age");
                    Program.Standing = adapter.GetString("Standing");
                    Program.Team = adapter.GetString("Team");
                    Class2 item = new Class2()
                    {
                        Name = Program.Name,
                        Surname = Program.Surname,
                        Birthday = Program.Birthday,
                        Age = Program.Age,
                        Standing = Program.Standing,
                        Team = Program.Team,

                    };
                    allbook2.Add(item);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd2;

            cmd2 = conn.CreateCommand();
            cmd2.CommandText = $"SELECT * FROM player WHERE  Name like\"%{name}%\" ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            adapter.Fill(ds);
            conn.Close();
            dataApplicants2.DataSource = ds.Tables[0].DefaultView;
        }
    }
    
}
