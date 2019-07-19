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
    public partial class tester_form : Form
    {
        private void init_set()
        {
            product_name_box.ResetText();
            company_name_box.ResetText();
            quantity_box.ResetText();
            period_box.ResetText();
            instagram_ck_box.Checked = false;
            youtube_ck_box.Checked = false;
            blog_ck_box.Checked = false;
            tester_ck_box.Checked = false;
            ambassador_ck_box.Checked = false;
            influencer_ck_box.Checked = false;
            req_box.Clear();
        }
        public tester_form()
        {
            
            InitializeComponent();
            init_set();
            Start_Connect_DB();

        }
        public enum Media_
        {
            Instagram,
            Youtube,
            Blog
        }
        public enum model_
        {
            Tester,
            Ambassador,
            Influencer
        }
        private void Start_Connect_DB()
        {
            string sql_ = "SELECT company_name, product_name FROM project_tbl";
            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            
            //try
            //{
                
                conn.Open();
                //MySqlCommand cmd = new MySqlCommand(sql_, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(sql_, conn);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                pjt_grid.DataSource = ds.Tables[0];
                conn.Close();
            //}
            
        }
        
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            init_set();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Write_btn_Click(object sender, EventArgs e)
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

            string sql_ = "SELECT count(*) FROM project_tbl WHERE product_name ='"+pd_name+"' and company_name = '"+cp_name+"'";

            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_;
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            
            if (result >0)
            {
                DataGridViewRow ck_dg = pjt_grid.SelectedRows[0];
                string old_pd_name = ck_dg.Cells[1].ToString();
                string old_cp_name = ck_dg.Cells[0].ToString();
                string sql = "UPDATE project_tbl SET product_name ='" + pd_name +
                    "', company_name ='" + cp_name +
                    "', quantity =" + quantity +
                    ", period =" + period +
                    ", Instagram =" + insta_ +
                    ", Youtube =" + youtu_ +
                    ", Blog =" + blog_ +
                    ", Tester =" + tester_ +
                    ", Ambassador =" + ambass_ +
                    ", Influencer =" + influe_ +
                    ", requirement ='" + req_ + 
                    "' WHERE product_name ='" + old_pd_name + 
                    "' and company_name = '" + old_cp_name + "'";
                MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                object result_up = cmd2.ExecuteNonQuery();

            }
            else
            {
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
                    "', 10)";
                MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                object result_up = cmd2.ExecuteNonQuery();
                
            }
            conn.Close();

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            Start_Connect_DB();
        }

        private void Pjt_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ck_dg = pjt_grid.SelectedRows[0];
            string target_pd_name = ck_dg.Cells[1].Value.ToString();
            string target_cp_name = ck_dg.Cells[0].Value.ToString();
            string sql_ = "SELECT * FROM project_tbl WHERE product_name ='" + target_pd_name + "' and company_name = '" + target_cp_name + "'";

            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                product_name_box.Text = rdr["product_name"].ToString();
                company_name_box.Text = rdr["company_name"].ToString();
                quantity_box.Text = rdr["quantity"].ToString();
                period_box.Text = rdr["period"].ToString();
                //media
                instagram_ck_box.Checked = Convert.ToBoolean(rdr["Instagram"]);
                youtube_ck_box.Checked = Convert.ToBoolean(rdr["Youtube"]);
                blog_ck_box.Checked = Convert.ToBoolean(rdr["Blog"]);
                //type
                tester_ck_box.Checked = Convert.ToBoolean(rdr["Tester"]);
                ambassador_ck_box.Checked = Convert.ToBoolean(rdr["Ambassador"]);
                influencer_ck_box.Checked = Convert.ToBoolean(rdr["Influencer"]);
                //client req
                req_box.Text = rdr["requirement"].ToString();
            }
            conn.Close();
        }
    }
}
