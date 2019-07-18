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

        }
        
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            init_set();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
