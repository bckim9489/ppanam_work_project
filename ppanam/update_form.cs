using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppanam
{
    public partial class update_form : Form
    {
        public update_form()
        {
            InitializeComponent();
            
        }

        private void Project_list_Click(object sender, EventArgs e)
        {
            show_labels();
        }
        private void show_labels()
        {
            if(prog_suc.Visible == true)
            {
                prog_here.Visible = false;
                contact_here.Visible = true;
                detail_prog.Value = 10;
            }
            if(contac_suc.Visible == true)
            {
                contact_here.Visible = false;
                deliv_influ_here.Visible = true;
                detail_prog.Value = 20;
            }
            if(deliv_influ_suc.Visible == true)
            {
                deliv_influ_here.Visible = false;
                media_upload_here.Visible = true;
                detail_prog.Value = 30;
            }
            if(media_upload_suc.Visible == true)
            {
                media_upload_here.Visible = false;
                tester_recruit_here.Visible = true;
                detail_prog.Value = 40;
            }
            if(tester_recruit_suc.Visible == true)
            {
                tester_recruit_here.Visible = false;
                tester_selec_here.Visible = true;
                detail_prog.Value = 50;
            }
            if(tester_selec_suc.Visible == true)
            {
                tester_selec_here.Visible = false;
                deliv_tester_here.Visible = true;
                detail_prog.Value = 60;
            }
            if(deliv_test_suc.Visible == true)
            {
                deliv_tester_here.Visible = false;
                test_review_here.Visible = true;
                detail_prog.Value = 70;
            }
            if(test_review_suc.Visible == true)
            {
                test_review_here.Visible = false;
                aggre_here.Visible = true;
                detail_prog.Value = 80;
            }
            if(aggre_suc.Visible == true)
            {
                aggre_here.Visible = false;
                send_comp_here.Visible = true;
                detail_prog.Value = 90;
            }
            if(send_suc.Visible == true)
            {
                send_comp_here.Visible = false;
                detail_prog.Value = 100;
            }
        }
    }
}
