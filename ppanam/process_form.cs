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
            ambassador_init_list();
            project_init_list();
        }

        private void ambassador_init_list()
        {
            amba_list.Items.Clear();
            string sql_ = "SELECT person_id, p_name, type FROM influencer_tbl WHERE blacklist = 0";

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
            string sql_ = "SELECT * FROM project_tbl";

            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string ty_flag = "";
                string youtube = "";
                string insta = "";
                string blog = "";
                ListViewItem lvt = new ListViewItem();
                lvt.Text = rdr["pid"].ToString();
                lvt.SubItems.Add(rdr["company_name"].ToString());
                lvt.SubItems.Add(rdr["product_name"].ToString());
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
                /*
                if (rdr["Tester"].ToString().Equals("1"))
                {
                    ty_flag += "1";
                }
                else
                {
                    ty_flag += "0";
                }
                if (rdr["Ambassador"].ToString().Equals("1"))
                {
                    ty_flag += "1";
                }
                else
                {
                    ty_flag += "0";
                }
                if (rdr["Influencer"].ToString().Equals("1"))
                {
                    ty_flag += "1";
                }
                else
                {
                    ty_flag += "0";
                }
                */
                lvt.SubItems.Add(youtube);
                lvt.SubItems.Add(insta);
                lvt.SubItems.Add(blog);
                lvt.SubItems.Add(rdr["requirement"].ToString());
                lvt.SubItems.Add(ty_flag);
                amba_pro_list.Items.Add(lvt);
                
            }
            conn.Close();
        }

        private void Amba_pro_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (amba_pro_list.SelectedIndices.Count > 0)
            {
                amba_list.Items.Clear();
                string pid = amba_pro_list.SelectedItems[0].SubItems[0].Text;
                string company_name = amba_pro_list.SelectedItems[0].SubItems[1].Text;
                string product_name = amba_pro_list.SelectedItems[0].SubItems[2].Text;
                string youtube = (amba_pro_list.SelectedItems[0].SubItems[3].Text == "Yes"? "1" : "0");
                string insta = (amba_pro_list.SelectedItems[0].SubItems[4].Text == "Yes" ? "1" : "0");
                string blog = (amba_pro_list.SelectedItems[0].SubItems[5].Text == "Yes" ? "1" : "0");
                string req = amba_pro_list.SelectedItems[0].SubItems[6].Text;
                int y_int = Convert.ToInt32(youtube);
                int i_int = Convert.ToInt32(insta);
                int b_int = Convert.ToInt32(blog);
                //int tp_flag =Convert.ToInt32(amba_pro_list.SelectedItems[0].SubItems[7].Text);
                string sql_sum = "";
                
                if ((y_int+i_int+b_int)!=0)
                {
                    sql_sum += " and (";
                    if (youtube.Equals("1"))
                    {
                        sql_sum += "youtube != '' ";
                        if (insta.Equals("1"))
                        {
                            sql_sum += "or instagram != ''";
                        }
                        if (blog.Equals("1"))
                        {
                            sql_sum += "or blog != ''";
                        }
                    }
                    else if (insta.Equals("1"))
                    {
                        sql_sum += "Instagram != '' ";
                        if (blog.Equals("1"))
                        {
                            sql_sum += "or Blog != ''";
                        }
                    }
                    else
                    {
                        sql_sum += "Blog != '' ";
                    }
                    sql_sum += ")";
                }
                
                string sql_ = "SELECT person_id, p_name, type, answer FROM influencer_tbl " +
                    "WHERE blacklist = 0 and status NOT LIKE '%Not%' and type = 'Ambassador'" +
                    "and project_id = 0"+sql_sum;

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
                    if (rdr["answer"].ToString().Equals("No"))
                    {
                        lvt.SubItems[1].Text += "  [ N ]";
                    }
                    amba_list.Items.Add(lvt);
                }
                conn.Close();
            }
        }
    }
}
