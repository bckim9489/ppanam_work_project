﻿using System;
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
	public partial class Form1 : Form
	{
        //bool tf_flag = false;

		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AppToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //----------------------------Click----------------------------------------------
        private void TesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)//창 열려 있는지 확인쓰
            {
                if (form.GetType() == typeof(tester_form))
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }
            tester_form tester_ = new tester_form();
            tester_.MdiParent = this;
            tester_.Dock = DockStyle.Fill;
            tester_.Show();
        }

        private void StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)//창 열려 있는지 확인쓰
            {
                if (form.GetType() == typeof(status_form))
                {
                    form.Activate();
                    //form.Close();
                    form.BringToFront();
                    return;
                }
            }
            status_form update_ = new status_form();
            update_.MdiParent = this;
            update_.Dock = DockStyle.Fill;
            update_.Show();
        }

        private void TeskUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)//창 열려 있는지 확인쓰
            {
                if (form.GetType() == typeof(process_form))
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }
            process_form proc_ = new process_form();
            proc_.MdiParent = this;
            proc_.Dock = DockStyle.Fill;
            proc_.Show();
        }

        private void ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)//창 열려 있는지 확인쓰
            {
                if (form.GetType() == typeof(influencer_form))
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            influencer_form proc_ = new influencer_form();
            proc_.MdiParent = this;
            proc_.Dock = DockStyle.Fill;
            proc_.Show();
        }

        private void TesterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)//창 열려 있는지 확인쓰
            {
                if (form.GetType() == typeof(Form2))
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            Form2 proc_ = new Form2();
            proc_.MdiParent = this;
            proc_.Dock = DockStyle.Fill;
            proc_.Show();
        }

        private void DeliveryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)//창 열려 있는지 확인쓰
            {
                if (form.GetType() == typeof(delivery_form))
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            delivery_form proc_ = new delivery_form();
            proc_.MdiParent = this;
            proc_.Dock = DockStyle.Fill;
            proc_.Show();
        }

        private void MediaUploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)//창 열려 있는지 확인쓰
            {
                if (form.GetType() == typeof(Form4))
                {
                    form.Activate();
                    form.BringToFront();
                    return;
                }
            }

            Form4 proc_ = new Form4();
            proc_.MdiParent = this;
            proc_.Dock = DockStyle.Fill;
            proc_.Show();
        }
    }
}
