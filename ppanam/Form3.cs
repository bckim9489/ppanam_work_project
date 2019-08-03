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
    public partial class Form3 : Form
    {
        Form2 frm1;
        string pid;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 _form, string _pid)
        {
            InitializeComponent();
            frm1 = _form;
            pid = _pid;
        }

        private void Crt_btn_Click(object sender, EventArgs e)
        {
            string strConn = "Server=175.204.17.171; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();

            string sql = "INSERT INTO tester_tbl values("+pid+", '"+ textBox1.Text +
                   "', '" + textBox2.Text +
                   "', '" + textBox3.Text +
                   "', '" + textBox4.Text +
                   "', '', 0)";
            MySqlCommand cmd2 = new MySqlCommand(sql, conn);
            cmd2.ExecuteNonQuery();

            conn.Close();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = pid;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.tester_init_list();
        }
    }
}
