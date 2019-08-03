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

namespace ppanam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tester_list.Items.Clear();
            te_pro_list.Items.Clear();
            project_list.Items.Clear();
            string sql_ = "SELECT * FROM project_tbl WHERE Tester = 1 and progress >= 40";
            string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem lvt = new ListViewItem();
                lvt.Text = rdr["pid"].ToString();
                lvt.SubItems.Add(rdr["company_name"].ToString());

                project_list.Items.Add(lvt);
            }
            richTextBox1.ReadOnly = true;
            button1.Visible = true;
            button4.Visible = false;
            conn.Close();


            conn.Open();
            sql_ = "SELECT * FROM project_tbl WHERE Tester = 1 AND progress >= 50";

            cmd.CommandText = sql_;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem lvt = new ListViewItem();
                lvt.Text = rdr["pid"].ToString();
                lvt.SubItems.Add(rdr["company_name"].ToString());

                te_pro_list.Items.Add(lvt);
            }
            conn.Close();


            conn.Open();
            sql_ = "SELECT explane FROM menual_tbl WHERE pid = 1";
            cmd.CommandText = sql_;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                richTextBox1.Text = rdr["explane"].ToString();
            }
            conn.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string pid = project_list.SelectedItems[0].SubItems[0].Text;

            string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            int result = 0;
            cmd.Connection = conn;
            string sql_ = "SELECT progress FROM project_tbl WHERE pid =" + pid;
            cmd.CommandText = sql_;
            object res = cmd.ExecuteScalar();
            int pg = (int)res;
            if (pg == 40)
            {
                sql_ = "UPDATE project_tbl SET progress = 50 WHERE pid =" + pid;
                cmd.CommandText = sql_;
                result = cmd.ExecuteNonQuery();
            }

            if (result != -1)
            {
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Can't doing");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string pid = project_list.SelectedItems[0].SubItems[0].Text;

            string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();

            cmd.Connection = conn;
            string sql_ = "SELECT COUNT(*) FROM influencer_tbl WHERE project_id =" + pid;
            cmd.CommandText = sql_;
            object res = cmd.ExecuteScalar();
            int result = (int)res;
            if (result != 0)
            {
                sql_ = "UPDATE project_tbl SET progress = 40 WHERE pid =" + pid;
                cmd.CommandText = sql_;
                result = cmd.ExecuteNonQuery();

            }
            else
            {
                sql_ = "UPDATE project_tbl SET progress = 10 WHERE pid =" + pid;
                cmd.CommandText = sql_;
                result = cmd.ExecuteNonQuery();
            }
            if (result != -1)
            {
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Can't doing");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            button4.Visible = true;
            button1.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button1.Visible = true;

            string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            string sql_ = "UPDATE menual_tbl SET explane = '" + richTextBox1.Text + "' WHERE pid = 1";
            cmd.CommandText = sql_;
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            sql_ = "SELECT explane FROM menual_tbl WHERE pid = 1";
            cmd.CommandText = sql_;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                richTextBox1.Text = rdr["explane"].ToString();
            }
            conn.Close();
            richTextBox1.ReadOnly = true;
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            if (te_pro_list.SelectedItems.Count > 0)
            {
                string pid = te_pro_list.SelectedItems[0].SubItems[0].Text;
                Form3 tmp_ = new Form3(this, pid);
                tmp_.Show();
            }
            else
            {
                MessageBox.Show("Select Project plz!");
            }
        }
        public void tester_init_list()
        {
            if (te_pro_list.SelectedItems.Count > 0)
            {
                tester_list.Items.Clear();
                string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
                MySqlConnection conn = new MySqlConnection(strConn);
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                string sql_ = "SELECT name FROM tester_tbl WHERE pid = " + te_pro_list.SelectedItems[0].Text;
                cmd.CommandText = sql_;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem lvt = new ListViewItem();
                    lvt.Text = rdr["name"].ToString();
                    tester_list.Items.Add(lvt);
                }
                conn.Close();
            }

        }
        public void tester_sel_init_list()
        {
            if (te_pro_list.SelectedItems.Count > 0)
            {
                listView1.Items.Clear();
                string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
                MySqlConnection conn = new MySqlConnection(strConn);
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                string sql_ = "SELECT name FROM tester_tbl WHERE selected = 1 and pid = " + te_pro_list.SelectedItems[0].Text;
                cmd.CommandText = sql_;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem lvt = new ListViewItem();
                    lvt.Text = rdr["name"].ToString();
                    listView1.Items.Add(lvt);
                }
                conn.Close();
            }

        }

        private void Te_pro_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (te_pro_list.SelectedItems.Count > 0)
            {
                tester_sel_init_list();
                tester_init_list();
            }

        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            if (tester_list.SelectedItems.Count > 0)
            {
                string sql_ = "DELETE FROM tester_tbl where  name ='" + tester_list.SelectedItems[0].Text + "' and pid =" + te_pro_list.SelectedItems[0].Text;

                string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql_;
                cmd.ExecuteNonQuery();
                conn.Close();
                tester_init_list();
            }
        }

        private void Tester_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tester_list.SelectedItems.Count > 0)
            {
                

                string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
                MySqlConnection conn = new MySqlConnection(strConn);
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                string sql_ = "SELECT * FROM tester_tbl WHERE pid = " + te_pro_list.SelectedItems[0].Text;
                cmd.CommandText = sql_;
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    textBox1.Text = rdr["name"].ToString();
                    textBox2.Text = rdr["email"].ToString();
                    textBox3.Text = rdr["address"].ToString();
                    textBox4.Text = rdr["option"].ToString();
                    comboBox1.Text = rdr["answer"].ToString();
                }
                conn.Close();
            }
        }

        private void Down_btn_Click(object sender, EventArgs e)
        {
            if (tester_list.SelectedItems.Count > 0)
            {
                ListViewItem tg = tester_list.SelectedItems[0];
                tester_list.Items.Remove(tg);
                listView1.Items.Add(tg);
                
            }
        }

        private void Up_btn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem tg = listView1.SelectedItems[0];
                listView1.Items.Remove(tg);
                tester_list.Items.Add(tg);
                
            }
        }

        private void Ap_btn_Click(object sender, EventArgs e)
        {
            string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            int cnt = listView1.Items.Count;
            int result = -1;
            if (cnt > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    string sqls = "UPDATE tester_tbl SET selected = 'Yes' WHERE pid = " + te_pro_list.SelectedItems[0].Text
                    + " and name = '" + listView1.Items[i].Text + "'";
                    cmd.CommandText = sqls;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                conn.Open();
                string pid = te_pro_list.SelectedItems[0].SubItems[0].Text;
                string sql_ = "SELECT progress FROM project_tbl WHERE pid =" + pid;
                cmd.CommandText = sql_;
                object res = cmd.ExecuteScalar();
                int pg = (int)res;
                if (pg == 50)
                {
                    sql_ = "UPDATE project_tbl SET progress = 60 WHERE pid =" + pid;
                    cmd.CommandText = sql_;
                    result = cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
            else
            {
                string pid = te_pro_list.SelectedItems[0].SubItems[0].Text;
                string sql_ = "SELECT progress FROM project_tbl WHERE pid =" + pid;
                cmd.CommandText = sql_;
                object res = cmd.ExecuteScalar();
                int pg = (int)res;
                if (pg == 60)
                {
                    sql_ = "UPDATE project_tbl SET progress = 50 WHERE pid =" + pid;
                    cmd.CommandText = sql_;
                    result = cmd.ExecuteNonQuery();
                }
            }
            
           
            if (result != -1)
            {
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Can't doing");
            }
        }
    }
}
