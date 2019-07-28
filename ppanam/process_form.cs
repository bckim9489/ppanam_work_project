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
    public partial class process_form : Form
    {
        public process_form()
        {
            InitializeComponent();
        }

        private void Process_form_Load(object sender, EventArgs e)
        {
            
            
        }

        private void ambassador_init_list()
        {
            amba_list.Items.Clear();
            string sql_ = "SELECT person_id, p_name FROM influencer_tbl WHERE blacklist = 0";

            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                ListViewItem lvt = new ListViewItem();
                lvt.Text = rdr["person_id"].ToString();
                lvt.SubItems.Add(rdr["p_name"].ToString());
                amba_list.Items.Add(lvt);
            }
            conn.Close();
        }

        private void project_init_list()
        {
            amba_pro_list.Items.Clear();
            string sql_ = "SELECT * FROM influencer_tbl WHERE blacklist = 0";

            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string youtube = "";
                string insta = "";
                string blog = "";
                ListViewItem lvt = new ListViewItem();
                lvt.Text = rdr["pid"].ToString();
                lvt.SubItems.Add(rdr["company_name"].ToString());
                lvt.SubItems.Add(rdr["pd_name"].ToString());
                if(Convert.ToInt32(rdr["Youtube"]) == 1)
                {
                    youtube = "Yes";
                }
                else
                {
                    youtube = "No";
                }
                if (Convert.ToInt32(rdr["Instagram"]) == 1)
                {
                    insta = "Yes";
                }
                else
                {
                    insta = "No";
                }
                if (Convert.ToInt32(rdr["Blog"]) == 1)
                {
                    blog = "Yes";
                }
                else
                {
                    blog = "No";
                }
                lvt.SubItems.Add(insta);
                lvt.SubItems.Add(youtube);
                lvt.SubItems.Add(blog);
                lvt.SubItems.Add(rdr["requirement"].ToString());
                amba_list.Items.Add(lvt);
            }
            conn.Close();
        }
    }
}
