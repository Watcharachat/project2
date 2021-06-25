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
    public partial class Form9 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            loaddata001();
            foreach (var i in allbook)
            {
                team1.Items.Add(i.Team);
                team2.Items.Add(i.Team);
                team3.Items.Add(i.Team);
                team4.Items.Add(i.Team);
                team5.Items.Add(i.Team);
                team6.Items.Add(i.Team);
                team7.Items.Add(i.Team);
                team8.Items.Add(i.Team);
                team9.Items.Add(i.Team);
                team10.Items.Add(i.Team);
                team11.Items.Add(i.Team);
                team12.Items.Add(i.Team);
                team13.Items.Add(i.Team);
                team14.Items.Add(i.Team);
                team15.Items.Add(i.Team);
                team16.Items.Add(i.Team);
            }
            inputscore();
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
        string winnamelol, losenamelol;
        int[] plol = new int[] { 0, 0, 0, 0, 0 }; int[] wlol = new int[] { 0, 0, 0, 0, 0 }; int[] llol = new int[] { 0, 0, 0, 0, 0 }; int[] flol = new int[] { 0, 0, 0, 0, 0 }; int[] alol = new int[] { 0, 0, 0, 0, 0 };
        private void round16_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(sc_t1.Text) > Convert.ToInt32(sc_t2.Text))
            {
                t1_r8.Text = team1.Text;
                winnamelol = team1.Text;
                losenamelol = team2.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t1.Text); alol[0] += Convert.ToInt32(sc_t2.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t2.Text); alol[0] += Convert.ToInt32(sc_t1.Text);
                staticclose();
                
            }
            else
            {
                t1_r8.Text = team2.Text;
                winnamelol = team2.Text;
                losenamelol = team1.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t2.Text); alol[0] += Convert.ToInt32(sc_t1.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t1.Text); alol[0] += Convert.ToInt32(sc_t2.Text);
                staticclose();
                
            }
            if (Convert.ToInt32(sc_t3.Text) > Convert.ToInt32(sc_t4.Text))
            {
                t2_r8.Text = team3.Text;
                winnamelol = team3.Text;
                losenamelol = team4.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t3.Text); alol[0] += Convert.ToInt32(sc_t4.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t4.Text); alol[0] += Convert.ToInt32(sc_t3.Text);
                staticclose();
                

            }
            else
            {
                t2_r8.Text = team4.Text;
                winnamelol = team4.Text;
                losenamelol = team3.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t4.Text); alol[0] += Convert.ToInt32(sc_t4.Text);
               staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t3.Text); alol[0] += Convert.ToInt32(sc_t4.Text);
                staticclose();
                
            }
            if (Convert.ToInt32(sc_t5.Text) > Convert.ToInt32(sc_t6.Text))
            {
                t3_r8.Text = team5.Text;
                winnamelol = team5.Text;
                losenamelol = team6.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t5.Text); alol[0] += Convert.ToInt32(sc_t6.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t6.Text); alol[0] += Convert.ToInt32(sc_t5.Text);
                staticclose();
            }
            else
            {
                t3_r8.Text = team6.Text;
                winnamelol = team6.Text;
                losenamelol = team5.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t6.Text); alol[0] += Convert.ToInt32(sc_t5.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t5.Text); alol[0] += Convert.ToInt32(sc_t6.Text);
                staticclose();
            }
            if (Convert.ToInt32(sc_t7.Text) > Convert.ToInt32(sc_t8.Text))
            {
                t4_r8.Text = team7.Text;
                winnamelol = team7.Text;
                losenamelol = team8.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t7.Text); alol[0] += Convert.ToInt32(sc_t8.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t8.Text); alol[0] += Convert.ToInt32(sc_t7.Text);
                staticclose();
            }
            else
            {
                t4_r8.Text = team8.Text;
                winnamelol = team8.Text;
                losenamelol = team7.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t8.Text); alol[0] += Convert.ToInt32(sc_t7.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t7.Text); alol[0] += Convert.ToInt32(sc_t8.Text);
                staticclose();
            }
            if (Convert.ToInt32(sc_t9.Text) > Convert.ToInt32(sc_t10.Text))
            {
                t5_r8.Text = team9.Text;
                winnamelol = team9.Text;
                losenamelol = team10.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t9.Text); alol[0] += Convert.ToInt32(sc_t10.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t10.Text); alol[0] += Convert.ToInt32(sc_t9.Text);
                staticclose();
            }
            else
            {
                t5_r8.Text = team10.Text;
                winnamelol = team10.Text;
                losenamelol = team9.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t10.Text); alol[0] += Convert.ToInt32(sc_t9.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t9.Text); alol[0] += Convert.ToInt32(sc_t10.Text);
                staticclose();

            }
            if (Convert.ToInt32(sc_t11.Text) > Convert.ToInt32(sc_t12.Text))
            {
                t6_r8.Text = team11.Text;
                winnamelol = team11.Text;
                losenamelol = team12.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t11.Text); alol[0] += Convert.ToInt32(sc_t12.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t12.Text); alol[0] += Convert.ToInt32(sc_t11.Text);
                staticclose();
            }
            else
            {
                t6_r8.Text = team12.Text;
                winnamelol = team12.Text;
                losenamelol = team11.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t12.Text); alol[0] += Convert.ToInt32(sc_t11.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t11.Text); alol[0] += Convert.ToInt32(sc_t12.Text);
                staticclose();
            }
            if (Convert.ToInt32(sc_t13.Text) > Convert.ToInt32(sc_t14.Text))
            {
                t7_r8.Text = team13.Text;
                winnamelol = team13.Text;
                losenamelol = team14.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t13.Text); alol[0] += Convert.ToInt32(sc_t14.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t14.Text); alol[0] += Convert.ToInt32(sc_t13.Text);
                staticclose();
            }
            else
            {
                t7_r8.Text = team14.Text;
                winnamelol = team14.Text;
                losenamelol = team13.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t14.Text); alol[0] += Convert.ToInt32(sc_t13.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t13.Text); alol[0] += Convert.ToInt32(sc_t14.Text);
                staticclose();
            }
            if (Convert.ToInt32(sc_t15.Text) > Convert.ToInt32(sc_t16.Text))
            {
                t8_r8.Text = team15.Text;
                winnamelol = team15.Text;
                losenamelol = team16.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t15.Text); alol[0] += Convert.ToInt32(sc_t16.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t16.Text); alol[0] += Convert.ToInt32(sc_t15.Text);
                staticclose();
            }
            else
            {
                t8_r8.Text = team16.Text;
                winnamelol = team16.Text;
                losenamelol = team15.Text;
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t16.Text); alol[0] += Convert.ToInt32(sc_t15.Text);
                staticcwin();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t15.Text); alol[0] += Convert.ToInt32(sc_t16.Text);
                staticclose();
            }

        }

        private void round8_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sc_t1r8.Text) > Convert.ToInt32(sc_t2r8.Text))
            {
                t1_r4.Text = t1_r8.Text;
                t1_r4.Text = t1_r8.Text;
                winnamelol = t1_r8.Text;
                losenamelol = t2_r8.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t1r8.Text); alol[0] += Convert.ToInt32(sc_t2r8.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t2r8.Text); alol[0] += Convert.ToInt32(sc_t1r8.Text);
                staticclose();
            }
            else
            {
                t1_r4.Text = t2_r8.Text;
                t1_r4.Text = t2_r8.Text;
                winnamelol = t2_r8.Text;
                losenamelol = t1_r8.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t2r8.Text); alol[0] += Convert.ToInt32(sc_t1r8.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t1r8.Text); alol[0] += Convert.ToInt32(sc_t2r8.Text);
                staticclose();
            }
            if (Convert.ToInt32(sc_t3r8.Text) > Convert.ToInt32(sc_t4r8.Text))
            {
                t2_r4.Text = t3_r8.Text;
                t2_r4.Text = t3_r8.Text;
                winnamelol = t3_r8.Text;
                losenamelol = t4_r8.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t3r8.Text); alol[0] += Convert.ToInt32(sc_t4r8.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t4r8.Text); alol[0] += Convert.ToInt32(sc_t3r8.Text);
                staticclose();
            }
            else
            {
                t2_r4.Text = t4_r8.Text;
                t2_r4.Text = t4_r8.Text;
                winnamelol = t4_r8.Text;
                losenamelol = t3_r8.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t4r8.Text); alol[0] += Convert.ToInt32(sc_t3r8.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t3r8.Text); alol[0] += Convert.ToInt32(sc_t4r8.Text);
                staticclose();
            }
            if (Convert.ToInt32(sc_t5r8.Text) > Convert.ToInt32(sc_t6r8.Text))
            {
                t3_r4.Text = t5_r8.Text;
                t3_r4.Text = t5_r8.Text;
                winnamelol = t5_r8.Text;
                losenamelol = t6_r8.Text;


                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t5r8.Text); alol[0] += Convert.ToInt32(sc_t6r8.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t6r8.Text); alol[0] += Convert.ToInt32(sc_t5r8.Text);
                staticclose();
            }
            else
            {
                t3_r4.Text = t6_r8.Text;
                t3_r4.Text = t6_r8.Text;
                winnamelol = t6_r8.Text;
                losenamelol = t5_r8.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t6r8.Text); alol[0] += Convert.ToInt32(sc_t5r8.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t5r8.Text); alol[0] += Convert.ToInt32(sc_t6r8.Text);
                staticclose();
            }
            if (Convert.ToInt32(sc_t7r8.Text) > Convert.ToInt32(sc_t8r8.Text))
            {
                t4_r4.Text = t7_r8.Text;
                t4_r4.Text = t7_r8.Text;
                winnamelol = t7_r8.Text;
                losenamelol = t8_r8.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t7r8.Text); alol[0] += Convert.ToInt32(sc_t8r8.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t8r8.Text); alol[0] += Convert.ToInt32(sc_t7r8.Text);
                staticclose();
            }
            else
            {
                t4_r4.Text = t8_r8.Text;
                t4_r4.Text = t8_r8.Text;
                winnamelol = t8_r8.Text;
                losenamelol = t7_r8.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t8r8.Text); alol[0] += Convert.ToInt32(sc_t7r8.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t7r8.Text); alol[0] += Convert.ToInt32(sc_t8r8.Text);
                staticclose();
            }
        }

        private void round4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sc_t1r4.Text) > Convert.ToInt32(sc_t2r4.Text))
            {
                ching1.Text = t1_r4.Text;
                ching1.Text = t1_r4.Text;
                winnamelol = t1_r4.Text;
                losenamelol = t2_r4.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t1r4.Text); alol[0] += Convert.ToInt32(sc_t2r4.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t2r8.Text); alol[0] += Convert.ToInt32(sc_t1r4.Text);
                staticclose();
            }
            else
            {
                ching1.Text = t2_r4.Text;
                ching1.Text = t2_r4.Text;
                winnamelol = t2_r4.Text;
                losenamelol = t1_r4.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t2r4.Text); alol[0] += Convert.ToInt32(sc_t1r4.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t1r8.Text); alol[0] += Convert.ToInt32(sc_t2r4.Text);
                staticclose();
            }
            if (Convert.ToInt32(sc_t3r4.Text) > Convert.ToInt32(sc_t4r4.Text))
            {
                ching2.Text = t3_r4.Text;
                ching2.Text = t3_r4.Text;
                winnamelol = t3_r4.Text;
                losenamelol = t4_r4.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t3r4.Text); alol[0] += Convert.ToInt32(sc_t4r4.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t4r8.Text); alol[0] += Convert.ToInt32(sc_t3r4.Text);
                staticclose();
            }
            else
            {
                ching2.Text = t4_r4.Text;
                ching2.Text = t4_r4.Text;
                winnamelol = t4_r4.Text;
                losenamelol = t3_r4.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_t4r4.Text); alol[0] += Convert.ToInt32(sc_t3r4.Text);
                staticcwin();


                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_t3r8.Text); alol[0] += Convert.ToInt32(sc_t4r4.Text);
                staticclose();
            }
        }

        private void championship_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(sc_ching1.Text) > Convert.ToInt32(sc_ching2.Text))
            {
                champion.Text = ching1.Text;
                champion.Text = ching1.Text;
                winnamelol = ching1.Text;
                losenamelol = ching2.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_ching1.Text); alol[0] += Convert.ToInt32(sc_ching2.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_ching2.Text); alol[0] += Convert.ToInt32(sc_ching1.Text);
                staticclose();
            }
            else
            {
                champion.Text = ching2.Text;
                champion.Text = ching2.Text;
                winnamelol = ching2.Text;
                losenamelol = ching1.Text;

                selectstaticcwin();
                plol[0] += 1; wlol[0] += 1; llol[0] += 0; flol[0] += Convert.ToInt32(sc_ching2.Text); alol[0] += Convert.ToInt32(sc_ching1.Text);
                staticcwin();

                selectstaticclose();
                plol[0] += 1; wlol[0] += 0; llol[0] += 1; flol[0] += Convert.ToInt32(sc_ching1.Text); alol[0] += Convert.ToInt32(sc_ching2.Text);
                staticclose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resettable();
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void staticcwin()
        {
            MySqlConnection conn = databaseConnection();

            string sql = "UPDATE statistics SET P = '" + plol[0] + "',W = '" + wlol[0] + "',L = '" + llol[0] + "',F = '" + flol[0] + "',A = '" + alol[0] + "' WHERE Team = '" + winnamelol + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            plol[0] = 0; wlol[0] = 0; llol[0] = 0; flol[0] = 0; alol[0] = 0;
            
        }
        private void staticclose()
        {
            MySqlConnection conn = databaseConnection();

            string sql = "UPDATE statistics SET P = '" + plol[0] + "',W = '" + wlol[0] + "',L = '" + llol[0] + "',F = '" + flol[0] + "',A = '" + alol[0] + "' WHERE Team = '" + losenamelol + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            plol[0] = 0; wlol[0] = 0; llol[0] = 0; flol[0] = 0; alol[0] = 0;
            
        }

        private void selectstaticcwin()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM statistics WHERE Team = '" + winnamelol + "'";


            MySqlDataReader row = cmd.ExecuteReader();
            row.Read();
            plol[0] = row.GetInt32("P");
            wlol[0] = row.GetInt32("W");
            llol[0] = row.GetInt32("L");
            flol[0] = row.GetInt32("F");
            alol[0] = row.GetInt32("A");
            conn.Close();
            
        }
        private void selectstaticclose()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM statistics WHERE Team = '" + losenamelol + "'";


            MySqlDataReader row = cmd.ExecuteReader();
            row.Read();
            plol[0] = row.GetInt32("P");
            wlol[0] = row.GetInt32("W");
            llol[0] = row.GetInt32("L");
            flol[0] = row.GetInt32("F");
            alol[0] = row.GetInt32("A");
            conn.Close();
            
        }

        
        

        private void resettable()
        {
            plol[0] = 0; wlol[0] = 0; llol[0] = 0; flol[0] = 0; alol[0] = 0;

            MySqlConnection conn = databaseConnection();

            string sql = "UPDATE statistics SET P = '" + 0 + "',W = '" + 0 + "',L = '" + 0 + "',F = '" + 0 + "',A = '" + 0 + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();
        }



        private void inputscore()
        {
            //sc_t1.Text = "1";
            //sc_t2.Text = "0";
            //sc_t3.Text = "1";
            //sc_t4.Text = "0";
            //sc_t5.Text = "1";
            //sc_t6.Text = "0";
            //sc_t7.Text = "1";
            //sc_t8.Text = "0";
            //sc_t9.Text = "1";
            //sc_t10.Text = "0";
            //sc_t11.Text = "1";
            //sc_t12.Text = "0";
            //sc_t13.Text = "1";
            //sc_t14.Text = "0";
            //sc_t15.Text = "1";
            //sc_t16.Text = "0";
        }

        private List<Class3> allbook3 = new List<Class3>();
        private void print_Click(object sender, EventArgs e)
        {
            allbook3.Clear();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString("สถิติการแข่งขันฟุตบอล รายการ ASANA FOOTBALL CLUB", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(195, 140));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 160));
            e.Graphics.DrawString("สถิติรวมการแข่งขันฟุตบอล", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(310, 192));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd / MM / yyyy   HH : mm : ss น."), new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(250, 215));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 240));
            e.Graphics.DrawString("Team", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(120, 255));
            e.Graphics.DrawString("P", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(250, 255));
            e.Graphics.DrawString("W", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(350, 255));
            e.Graphics.DrawString("L", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(450, 255));
            e.Graphics.DrawString("F", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(550, 255));
            e.Graphics.DrawString("A", new Font("TH SarabunPSK", 16, FontStyle.Bold), Brushes.Black, new PointF(650, 255));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------", new Font("TH SarabunPSK", 18, FontStyle.Bold), Brushes.Black, new PointF(50, 265));
            int y = 290;
            loaddata();
            foreach (var i in allbook3)
            {
                e.Graphics.DrawString(i.Team, new Font("TH SarabunPSK", 18, FontStyle.Regular), Brushes.Black, new PointF(120, y));
                e.Graphics.DrawString(i.P, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(250, y));
                e.Graphics.DrawString(i.W, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(350, y));
                e.Graphics.DrawString(i.L, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(450, y));
                e.Graphics.DrawString(i.F, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(550, y));
                e.Graphics.DrawString(i.A, new Font("TH SarabunPSK", 16, FontStyle.Regular), Brushes.Black, new PointF(650, y));

                y = y + 20;

            }

        }
        private void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project;");

            conn.Open();

            
            
            {

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM statistics ", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.Team = adapter.GetString("Team");
                    Program.P = adapter.GetString("P");
                    Program.W = adapter.GetString("W");
                    Program.L = adapter.GetString("L");
                    Program.F = adapter.GetString("F");
                    Program.A = adapter.GetString("A");

                    Class3 item = new Class3()
                    {
                        Team = Program.Team,
                        P = Program.P,
                        W = Program.W,
                        L = Program.L,
                        F = Program.F,
                        A = Program.A,


                    };
                    allbook3.Add(item);
                }
            
            
                

            }
        }
    }
}
