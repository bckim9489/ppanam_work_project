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
        int req_flag = 0;
        int m_flag = 0;
        int fe_flag = 0;

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

        private string[] Parser_func(int flag)
        {
            string[] result = { "0" } ;
            if (flag != 0)
            {
                string parse_target = amba_pro_list.SelectedItems[0].SubItems[6].Text;
                //int index_key = 0;
                char sp = '#';
                string[] parse_string = parse_target.Split(sp);
                return parse_string;
            }
            return result;
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
                selected_list.Items.Clear();
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
                string[] opt = Parser_func(req_flag);
                /*
                for (int i = 0; i<opt.Length; i++)
                {
                    System.Console.WriteLine(opt[i]);
                }
                */
                
                if (req_flag != 0 && !opt.Equals("0") && req.Contains('#') == true)
                {
                    int j = opt.Length -2;
                    sql_sum += " and (";
                    System.Console.WriteLine(opt.Length);
                    System.Console.WriteLine(j);
                    for (int i = 1; i<opt.Length; i++)
                    {
                        sql_sum += " orientation LIKE '%"+opt[i]+"%' ";
                        if (j > 0)
                        {
                            sql_sum += "or";
                            j--;
                        }

                    }
                    sql_sum += ")";
                }
                if(fe_flag == 1 || m_flag == 1)
                {
                    sql_sum += " and (";
                    if (fe_flag != 0 && m_flag != 1)
                    {
                        sql_sum += "gender = 'Female'";
                    }
                    if (m_flag != 0 && fe_flag != 1)
                    {
                        sql_sum += "gender = 'Male'";
                    }
                    if (m_flag != 0 && fe_flag != 0)
                    {
                        sql_sum += "gender = 'Male' or gender = 'Female'";
                    }
                    sql_sum += " )";

                }
                
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

                sql_ = "SELECT person_id, p_name, type, answer FROM influencer_tbl " +
                    "WHERE blacklist = 0 and type = 'Ambassador'" +
                    "and project_id = " + pid;
                conn.Close();
                conn.Open();
                cmd.CommandText = sql_;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListViewItem lvt = new ListViewItem();
                    lvt.Text = rdr["person_id"].ToString();
                    lvt.SubItems.Add(rdr["p_name"].ToString());
                    if (rdr["answer"].ToString().Equals("No"))
                    {
                        lvt.SubItems[1].Text += "  [ N ]";
                    }
                    selected_list.Items.Add(lvt);
                }
                conn.Close();
            }
        }

        private void Push_btn_Click(object sender, EventArgs e)
        {
            if(amba_list.SelectedItems.Count > 0)
            {
                ListViewItem lvt = amba_list.SelectedItems[0];
                amba_list.Items.Remove(lvt);
                selected_list.Items.Add(lvt);
            }
        }

        private void Pop_button_Click(object sender, EventArgs e)
        {
            
            if(selected_list.SelectedItems.Count > 0)
            {
                ListViewItem lvt = selected_list.SelectedItems[0];
                selected_list.Items.Remove(lvt);
                amba_list.Items.Add(lvt);
            }
            
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            project_init_list();
            ambassador_init_list();
        }

        private void Conf_btn_Click(object sender, EventArgs e)
        {
            int result = 0;
            int result2 = 0;
            int cnt = selected_list.Items.Count;
            if (cnt > 0)
            {
                for (int i = 0; i < selected_list.Items.Count; i++)
                {
                    string person_id = selected_list.Items[i].SubItems[0].Text;
                    string pid = amba_pro_list.SelectedItems[0].SubItems[0].Text;
                    string sql_ = "UPDATE influencer_tbl SET project_id = " + pid + " WHERE person_id = " + person_id;
                    string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
                    MySqlConnection conn = new MySqlConnection(strConn);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql_;
                    result = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            cnt = amba_list.Items.Count;
            if(cnt > 0)
            {
                for (int i = 0; i < amba_list.Items.Count; i++)
                {
                    string person_id = amba_list.Items[i].SubItems[0].Text;
                    string pid = "0";
                    string sql_ = "UPDATE influencer_tbl SET project_id = " + pid + " WHERE person_id = " + person_id;
                    string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
                    MySqlConnection conn = new MySqlConnection(strConn);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sql_;
                    result2 = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            
            if (result != -1 && result2 != -1)
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Can't Apply");
            }
        }
        private void Apply_reset()
        {
            req_ch_box.Checked = false;
            male_box.Checked = false;
            female_box.Checked = false;
            req_flag = 0;
            m_flag = 0;
            fe_flag = 0;
        }
        private void Apply_btn_Click(object sender, EventArgs e)
        {
            if(req_ch_box.Checked == true)
            {
                req_flag = 1;
            }
            else
            {
                req_flag = 0;
            }
            if(male_box.Checked == true)
            {
                m_flag = 1;
            }
            else
            {
                m_flag = 0;
            }
            if (female_box.Checked == true)
            {
                fe_flag = 1;
            }
            else
            {
                fe_flag = 0;
            }


        }
    }
}
