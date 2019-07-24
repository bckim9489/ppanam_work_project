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
    public partial class influencer_form : Form
    {
        public influencer_form()
        {
            InitializeComponent();
        }
        private void init_list()
        {
            string sql_ = "SELECT person_id, p_name FROM influencer_tbl";
            influ_list.Items.Clear();
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
                influ_list.Items.Add(lvt);
            }
            conn.Close();
        }
        private void Influencer_form_Load(object sender, EventArgs e)
        {
            init_list();
        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            init_list();
        }

        private void Influ_list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //TODO - add "Project_log" Function, Image Function
            if (influ_list.SelectedIndices.Count > 0)
            {
                string person_id = influ_list.SelectedItems[0].SubItems[0].Text;
                string p_name = influ_list.SelectedItems[0].SubItems[1].Text;

                string sql_ = "SELECT * FROM influencer_tbl WHERE p_name = '" + p_name + "' and person_id =" + person_id;
                string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql_;
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    name_box.Text = rdr["p_name"].ToString();
                    Insta_box.Text = rdr["instagram"].ToString();
                    you_box.Text = rdr["youtube"].ToString();
                    blog_box.Text = rdr["blog"].ToString();
                    foll_box.Text = rdr["follower"].ToString();
                    subs_box.Text = rdr["subscriber"].ToString();
                    orient_box.Text = rdr["orientation"].ToString();
                    emali_box.Text = rdr["email"].ToString();
                    status_box.Text = rdr["status"].ToString();
                    ans_box.Text = rdr["answer"].ToString();
                    black_ch_box.Checked = Convert.ToBoolean(rdr["blacklist"]);
                    string sql = "SELECT company_name FROM project_tbl WHERE pid = " + rdr["project_id"].ToString();
                    MySqlConnection conn2 = new MySqlConnection(strConn);
                    MySqlCommand cmd_ = new MySqlCommand();
                    cmd_.Connection = conn2;
                    cmd_.CommandText = sql;
                    
                    conn2.Open();
                    object rdr2 = cmd_.ExecuteScalar();
                    p_box.Text = (string)rdr2;
                    conn2.Close();
                }
                conn.Close();
            }
        }
    }
}
