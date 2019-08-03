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
    public partial class delivery_form : Form
    {
        public delivery_form()
        {
            InitializeComponent();
        }

        private void Delivery_form_Load(object sender, EventArgs e)
        {
            string sql_ = "SELECT * FROM project_tbl WHERE Ambassador = 1 and progress >= 20";
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
            sql_ = "SELECT * FROM project_tbl WHERE Tester = 1 and progress >= 60";
            cmd.CommandText = sql_;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem lvt = new ListViewItem();
                lvt.Text = rdr["pid"].ToString();
                lvt.SubItems.Add(rdr["company_name"].ToString());

                listView1.Items.Add(lvt);
            }
            richTextBox2.ReadOnly = true;
            button5.Visible = true;
            button6.Visible = false;
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
            if (pg == 20)
            {
                sql_ = "UPDATE project_tbl SET progress = 30 WHERE pid =" + pid;
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
                sql_ = "UPDATE project_tbl SET progress = 20 WHERE pid =" + pid;
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
            string sql_ = "UPDATE menual_tbl SET explane = '" + richTextBox1.Text + "' WHERE pid = 2";
            cmd.CommandText = sql_;
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            sql_ = "SELECT explane FROM menual_tbl WHERE pid = 2";
            cmd.CommandText = sql_;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                richTextBox1.Text = rdr["explane"].ToString();
            }
            conn.Close();
            richTextBox1.ReadOnly = true;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string pid = listView1.SelectedItems[0].SubItems[0].Text;

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
            if (pg == 60)
            {
                sql_ = "UPDATE project_tbl SET progress = 70 WHERE pid =" + pid;
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

        private void Button5_Click(object sender, EventArgs e)
        {
            richTextBox2.ReadOnly = false;
            button6.Visible = true;
            button5.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            button5.Visible = true;

            string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand();
            conn.Open();
            cmd.Connection = conn;
            string sql_ = "UPDATE menual_tbl SET explane = '" + richTextBox2.Text + "' WHERE pid = 4";
            cmd.CommandText = sql_;
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            sql_ = "SELECT explane FROM menual_tbl WHERE pid = 4";
            cmd.CommandText = sql_;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                richTextBox2.Text = rdr["explane"].ToString();
            }
            conn.Close();
            richTextBox2.ReadOnly = true;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string pid = listView1.SelectedItems[0].SubItems[0].Text;

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
                sql_ = "UPDATE project_tbl SET progress = 60 WHERE pid =" + pid;
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
    }
}
