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
    public partial class update_form : Form
    {
        public update_form()
        {
            InitializeComponent();
        }
        private void init_status()
        {
            prog_suc.Visible = false;
            prog_here.Visible = false;
            contac_suc.Visible = false;
            contact_here.Visible = false;
            deliv_influ_suc.Visible = false;
            deliv_influ_here.Visible = false;
            media_upload_suc.Visible = false;
            media_upload_here.Visible = false;
            tester_recruit_suc.Visible = false;
            tester_recruit_here.Visible = false;
            tester_selec_suc.Visible = false;
            tester_selec_here.Visible = false;
            deliv_test_suc.Visible = false;
            deliv_tester_here.Visible = false;
            test_review_suc.Visible = false;
            test_review_here.Visible = false;
            aggre_suc.Visible = false;
            aggre_here.Visible = false;
            send_comp_here.Visible = false;
            send_comp_here.Visible = false;
            detail_prog.Value = 0;
        }
        private void Project_list_Click(object sender, EventArgs e)
        {
             
        }
        private void show_labels(int detail_value)
        {
            
            if (detail_value >= 10)
            {
                prog_suc.Visible = true;
                prog_here.Visible = false;
                contact_here.Visible = true;
                detail_prog.Value = 10;
            }
            if(detail_value >= 20)
            {
                contac_suc.Visible = true;
                contact_here.Visible = false;
                deliv_influ_here.Visible = true;
                detail_prog.Value = 20;
            }
            if(detail_value >= 30)
            {
                deliv_influ_suc.Visible = true;
                deliv_influ_here.Visible = false;
                media_upload_here.Visible = true;
                detail_prog.Value = 30;
            }
            if(detail_value >= 40)
            {
                media_upload_suc.Visible = true;
                media_upload_here.Visible = false;
                tester_recruit_here.Visible = true;
                detail_prog.Value = 40;
            }
            if(detail_value >= 50)
            {
                tester_recruit_suc.Visible = true;
                tester_recruit_here.Visible = false;
                tester_selec_here.Visible = true;
                detail_prog.Value = 50;
            }
            if(detail_value >= 60)
            {
                tester_selec_suc.Visible = true;
                tester_selec_here.Visible = false;
                deliv_tester_here.Visible = true;
                detail_prog.Value = 60;
            }
            if(detail_value >= 70)
            {
                deliv_test_suc.Visible = true;
                deliv_tester_here.Visible = false;
                test_review_here.Visible = true;
                detail_prog.Value = 70;
            }
            if(detail_value >= 80)
            {
                test_review_suc.Visible = true;
                test_review_here.Visible = false;
                aggre_here.Visible = true;
                detail_prog.Value = 80;
            }
            if(detail_value >= 90)
            {
                aggre_suc.Visible = true;
                aggre_here.Visible = false;
                send_comp_here.Visible = true;
                detail_prog.Value = 90;
            }
            if(detail_value >= 100)
            {
                send_comp_here.Visible = true;
                send_comp_here.Visible = false;
                detail_prog.Value = 100;
            }
        }

        private void show_list()
        {
            string sql_ = "SELECT product_name, pid, company_name FROM project_tbl";

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
                lvt.Text = rdr["pid"].ToString();
                lvt.SubItems.Add(rdr["product_name"].ToString());
                lvt.SubItems.Add(rdr["company_name"].ToString());
                project_list.Items.Add(lvt);
            }
            conn.Close();
        }

        private void Update_form_Load(object sender, EventArgs e)
        {
            project_list.Columns.Add("PID", 40);
            project_list.Columns.Add("Product",140);
            project_list.Columns.Add("Company", 160);
            show_list();
            init_status();
        }

        private void Project_list_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (project_list.SelectedIndices.Count > 0)
            {
                init_status();
                int detail_value = 0;

                string pid = project_list.SelectedItems[0].SubItems[0].Text;
                string p_name = project_list.SelectedItems[0].SubItems[1].Text;

                string sql_ = "SELECT progress FROM project_tbl WHERE product_name = '" + p_name + "' and pid =" + pid;
                string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql_;
                detail_value = (int)(cmd.ExecuteScalar());

                show_labels(detail_value);

                conn.Close();
            }
        }

        private void Load_btn_Click(object sender, EventArgs e)
        {
            project_list.Items.Clear();
            show_list();
        }
    }
}