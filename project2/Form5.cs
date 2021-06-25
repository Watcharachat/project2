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
    public partial class Form5 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void showApplicants4()
        {
            string name = search2.Text;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet(); 
            conn.Open();

            MySqlCommand cmd2;

            cmd2 = conn.CreateCommand();
            cmd2.CommandText = $"SELECT * FROM player WHERE  Name like\"%{name}%\" ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            adapter.Fill(ds);
            conn.Close();
            dataApplicants4.DataSource = ds.Tables[0].DefaultView;

        }

        public Form5()
        {
            InitializeComponent();
            search2.Text = Program.Name;
            

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        

        private void Back2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            this.Hide();
            a.Show();
        }

        private void Exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private List<Class1> allbook = new List<Class1>();

        private void Print_Click(object sender, EventArgs e)
        {
            allbook.Clear();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString("สโมสรฟุตบอล ASANA FOOTBALL CLUB", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(260, 140));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(36, 160));
            e.Graphics.DrawString("รายการข้อมูลผู้สมัครเข้าร่วมการแข่งขัน", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 192));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 215));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(36, 240));
            e.Graphics.DrawString("ชื่อ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(93, 350));
            e.Graphics.DrawString("นาามสกุล", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(350, 350));
            e.Graphics.DrawString("วันเกิด", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(590, 350));
            e.Graphics.DrawString("อายุ", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(93, 400));
            e.Graphics.DrawString("เบอร์โทร", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(350, 400));
            e.Graphics.DrawString("ส่วนสูง", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(590, 400));
            e.Graphics.DrawString("น้ำหนัก", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(93, 450));
            e.Graphics.DrawString("เท้าข้างถนัด", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(350, 450));
            e.Graphics.DrawString("ตำแหน่ง", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(590, 450));
            e.Graphics.DrawString("ทีม", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(93, 500));
            e.Graphics.DrawString("ที่อยู่", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(355, 500));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(38, 265));
            int y = 290;
            loaddata();
            foreach (var i in allbook)
            {
                e.Graphics.DrawString(i.Name, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(195, 350));
                e.Graphics.DrawString(i.Surname, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(450, 350));
                e.Graphics.DrawString(i.Birthday, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(680, 350));
                e.Graphics.DrawString(i.Age, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(200, 400));
                e.Graphics.DrawString(i.Phonenumber, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(450, 400));
                e.Graphics.DrawString(i.Height, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(680, 400));
                e.Graphics.DrawString(i.Weight, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(200, 450));
                e.Graphics.DrawString(i.Dominant_Foot, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(450, 450));
                e.Graphics.DrawString(i.Standing, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(680, 450));
                e.Graphics.DrawString(i.Team, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(200, 500));
                e.Graphics.DrawString(i.Address, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(450, 500));

                y = y + 20;


            }
        }
            private void loaddata()
            {
                MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project;");

                conn.Open();

                string name = search2.Text;
                if (name == "")
                {

                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM player ", conn);
                    MySqlDataReader adapter = cmd.ExecuteReader();

                    while (adapter.Read())
                    {
                        Program.Name = adapter.GetString("Name");
                        Program.Surname = adapter.GetString("Surname");
                        Program.Birthday = adapter.GetString("Birthday");
                        Program.Age = adapter.GetString("Age");
                        Program.Address = adapter.GetString("Address");
                        Program.Height = adapter.GetString("Height");
                        Program.Weight = adapter.GetString("Weight");
                        Program.Dominant_Foot = adapter.GetString("Dominant_Foot");
                        Program.Standing = adapter.GetString("Standing");
                        Program.Phonenumber = adapter.GetString("Phonenumber");
                        Program.Team = adapter.GetString("Team");
                        Class1 item = new Class1()
                        {
                            Name = Program.Name,
                            Surname = Program.Surname,
                            Birthday = Program.Birthday,
                            Age = Program.Age,
                            Address = Program.Address,
                            Height = Program.Height,
                            Weight = Program.Weight,
                            Dominant_Foot = Program.Dominant_Foot,
                            Standing = Program.Standing,
                            Phonenumber = Program.Phonenumber,
                            Team = Program.Team,
                        };
                        allbook.Add(item);
                    }
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM player WHERE Name=\"{name}\" ",conn);
                    MySqlDataReader adapter = cmd.ExecuteReader();

                    while (adapter.Read())
                    {
                    Program.Name = adapter.GetString("Name");
                    Program.Surname = adapter.GetString("Surname");
                    Program.Birthday = adapter.GetString("Birthday");
                    Program.Age = adapter.GetString("Age");
                    Program.Address = adapter.GetString("Address");
                    Program.Height = adapter.GetString("Height");
                    Program.Weight = adapter.GetString("Weight");
                    Program.Dominant_Foot = adapter.GetString("Dominant_Foot");
                    Program.Standing = adapter.GetString("Standing");
                    Program.Phonenumber = adapter.GetString("Phonenumber");
                    Program.Team = adapter.GetString("Team");
                    Class1 item = new Class1()
                    {
                        Name = Program.Name,
                        Surname = Program.Surname,
                        Birthday = Program.Birthday,
                        Age = Program.Age,
                        Address = Program.Address,
                        Height = Program.Height,
                        Weight = Program.Weight,
                        Dominant_Foot = Program.Dominant_Foot,
                        Standing = Program.Standing,
                        Phonenumber = Program.Phonenumber,
                        Team = Program.Team,

                    };
                        allbook.Add(item);
                    }

                }
            conn.Close();
            }

        private void search2_TextChanged(object sender, EventArgs e)
        {
            string name = search2.Text;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd2;

            cmd2 = conn.CreateCommand();
            cmd2.CommandText = $"SELECT * FROM player WHERE  Name like\"%{name}%\" ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            adapter.Fill(ds);
            conn.Close();
            dataApplicants4.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
