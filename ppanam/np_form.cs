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
using MySql.Data.Common;

namespace ppanam
{
    public partial class np_form : Form
    {
        tester_form frm1;
        public np_form()
        {
            InitializeComponent();
        }
        public np_form(tester_form _form)
        {
            InitializeComponent();
            frm1 = _form;
        }

        private void Done_btn_Click(object sender, EventArgs e)
        {
            //client info
            string pd_name = product_name_box.Text;
            string cp_name = company_name_box.Text;
            string quantity = quantity_box.Text;
            string period = period_box.Text;
            //media
            bool insta_ = instagram_ck_box.Checked;
            bool youtu_ = youtube_ck_box.Checked;
            bool blog_ = blog_ck_box.Checked;
            //type
            bool tester_ = tester_ck_box.Checked;
            bool ambass_ = ambassador_ck_box.Checked;
            bool influe_ = influencer_ck_box.Checked;
            //client req
            string req_ = req_box.Text;

            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();

            string sql = "INSERT INTO project_tbl values('" + pd_name +
                   "', '" + cp_name +
                   "', " + quantity +
                   ", " + period +
                   ", " + insta_ +
                   ", " + youtu_ +
                   ", " + blog_ +
                   ", " + tester_ +
                   ", " + ambass_ +
                   ", " + influe_ +
                   ", '" + req_ +
                   "', 10,0)";
            MySqlCommand cmd2 = new MySqlCommand(sql, conn);
            cmd2.ExecuteNonQuery();

            conn.Close();
            this.Close();
        }

        private void Np_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.Start_Connect_DB();
        }
    }
}
