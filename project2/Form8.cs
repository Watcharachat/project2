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
    public partial class Form8 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project;charset=utf8;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }


        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            ShowGridView1();
        }

        private void ShowGridView1()
        {
            
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd2;

            cmd2 = conn.CreateCommand();
            cmd2.CommandText = "SELECT * FROM team";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           nameteam.Text = dataGridView1.Rows[e.RowIndex].Cells["Team"].FormattedValue.ToString();
            Program.Changteam = nameteam.Text;
        }

        private void addteam_Click(object sender, EventArgs e)
        {
            if ( nameteam.Text != "")
            {
                MySqlConnection conn = databaseConnection();
                String sql = "INSERT INTO team (Team) VALUES('" + nameteam.Text + "')";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                    ShowGridView1();
                    nameteam.Clear();
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
        }

        private void editteam_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["id"].Value);
            if ( nameteam.Text != "")
            {

                {
                    MySqlConnection conn = databaseConnection();

                    string sql = "UPDATE team SET Team = '" + nameteam.Text + "'WHERE id= '" + editId + "'";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();


                    int rows = cmd.ExecuteNonQuery();
                    

                    conn.Close();
                   

                    if (rows > 0)
                    {
                        Chang();
                        MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                        
                        nameteam.Clear();
                        ShowGridView1();
                        




                    }
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ");
            }
        }

        private void deletteam_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells["id"].Value);

            {

                MySqlConnection conn = databaseConnection();

                String sql = "DELETE FROM team WHERE id = '" + deleteId + "'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                conn.Close();
                if (rows > 0)
                {
                    ShowGridView1();
                    MessageBox.Show("ลบข้อมูลสำเร็จ");
                    nameteam.Clear();
                    Chang();



                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            this.Hide();
            a.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string team = search.Text;
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd2;

            cmd2 = conn.CreateCommand();
            cmd2.CommandText = $"SELECT * FROM team WHERE  Team like\"%{team}%\" ";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd2);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void Chang()
        {
            MySqlConnection conn = databaseConnection();

            string sql = "UPDATE player SET Team = '" + nameteam.Text + "'WHERE Team =  '" + Program.Changteam + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();


            int rows = cmd.ExecuteNonQuery();
            //MySqlDataReader row = cmd.ExecuteReader();
            //row.Read();
            //Program.Changteam = row.GetString("Team");

            conn.Close();
        }
    }
}

