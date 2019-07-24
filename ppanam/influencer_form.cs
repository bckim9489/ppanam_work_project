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
    }
}
