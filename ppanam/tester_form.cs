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
        public void Start_Connect_DB() //FIXME : require DB_connect function -> classful
        {
            string sql_ = "SELECT company_name, product_name FROM project_tbl";
            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            //string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            //External IP 175.204.17.171, Internal IP 192.168.0.23;
            MySqlConnection conn = new MySqlConnection(strConn);

            conn.Open();
            //MySqlCommand cmd = new MySqlCommand(sql_, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(sql_, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            pjt_grid.DataSource = ds.Tables[0];
            conn.Close();
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
            
            DataGridViewRow ck_dg = pjt_grid.SelectedRows[0];
            string old_pd_name = ck_dg.Cells[1].Value.ToString();
            string old_cp_name = ck_dg.Cells[0].Value.ToString();

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

            string sql_ = "SELECT pid FROM project_tbl WHERE product_name ='"+old_pd_name+"' and company_name = '"+old_cp_name+"'";

            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_;
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            
            if (result >0)
            {
                
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
                    "' WHERE pid ="+result;
                MySqlCommand cmd2 = new MySqlCommand(sql, conn);
                cmd2.ExecuteNonQuery();
            }
            
            conn.Close();
            Start_Connect_DB();
            repair_btn.Visible = true;
            write_btn.Visible = false;
            clear_btn.Visible = false;
            read_only_set();

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

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow ck_dg = pjt_grid.SelectedRows[0];
            string target_pd_name = ck_dg.Cells[1].Value.ToString();
            string target_cp_name = ck_dg.Cells[0].Value.ToString();
            string sql_ = "DELETE FROM project_tbl where  product_name ='" + target_pd_name + "' and company_name = '" + target_cp_name + "'";

            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql_;
            cmd.ExecuteNonQuery();
            conn.Close();
            Start_Connect_DB();
        }

        private void Repair_btn_Click(object sender, EventArgs e)
        {
            repair_btn.Visible = false;
            write_btn.Visible = true;
            clear_btn.Visible = true;
            mod_set();
        }

        private void Tester_form_Load(object sender, EventArgs e)
        {
            clear_btn.Visible = false;
            read_only_set();
        }
        private void read_only_set()
        {
            product_name_box.ReadOnly = true;
            company_name_box.ReadOnly = true;
            quantity_box.ReadOnly = true;
            period_box.ReadOnly = true;
            //media
            instagram_ck_box.Enabled = false;
            youtube_ck_box.Enabled = false;
            blog_ck_box.Enabled = false;
            //type
            tester_ck_box.Enabled = false;
            ambassador_ck_box.Enabled = false;
            influencer_ck_box.Enabled = false;
            //client req
            req_box.ReadOnly = true;
        }
        private void mod_set()
        {
            product_name_box.ReadOnly = false;
            company_name_box.ReadOnly = false;
            quantity_box.ReadOnly = false;
            period_box.ReadOnly = false;
            //media
            instagram_ck_box.Enabled = true;
            youtube_ck_box.Enabled = true;
            blog_ck_box.Enabled = true;
            //type
            tester_ck_box.Enabled = true;
            ambassador_ck_box.Enabled = true;
            influencer_ck_box.Enabled = true;
            //client req
            req_box.ReadOnly = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            np_form ne_ = new np_form(this);
            ne_.ShowDialog();
        }
    }
}
