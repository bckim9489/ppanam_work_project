﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            Readonly_Mode();
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

        private void Readonly_Mode()
        {
            name_box.ReadOnly = true;
            Insta_box.ReadOnly = true;
            you_box.ReadOnly = true;
            blog_box.ReadOnly = true;
            foll_box.ReadOnly = true;
            subs_box.ReadOnly = true;
            orient_box.ReadOnly = true;
            emali_box.ReadOnly = true;
            status_box.Enabled = false;
            ans_box.Enabled = false;
            pic_uplo_btn.Visible = false;
            up_btn.Visible = false;
            mod_btn.Visible = true;
            p_box.ReadOnly = true;
        }

        private void Modify_Mode()
        {
            name_box.ReadOnly = false;
            Insta_box.ReadOnly = false;
            you_box.ReadOnly = false;
            blog_box.ReadOnly = false;
            foll_box.ReadOnly = false;
            subs_box.ReadOnly = false;
            orient_box.ReadOnly = false;
            emali_box.ReadOnly = false;
            status_box.Enabled = true;
            ans_box.Enabled = true;
            pic_uplo_btn.Visible = true;
            up_btn.Visible = true;
            mod_btn.Visible = false;
            p_box.ReadOnly = false;
        }

        private void pic_file()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.Tag = ofd.FileName;

            }

        }
        private void img_load(int person_id)
        {
            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();

            string qury = "SELECT img FROM influencer_tbl, WHERE  person_id = " + person_id;
            MySqlDataReader rdr;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = qury;

            rdr = cmd.ExecuteReader();
            int result = 0;
            int result2 = 0;
            while (rdr.Read())
            {
                result = Convert.ToInt32(rdr["person_id"].ToString());
                if (rdr["img"] != DBNull.Value)
                {
                    result2 = 1;
                }
            }

            if ((result != 0) && (result2 != 0))
            {
                qury = "select img from influencer_tbl where person_id = " + person_id;
                cmd.CommandText = qury;
                rdr = cmd.ExecuteReader();
                byte[] bImage = null;
                while (rdr.Read())
                {
                    bImage = (byte[])rdr[0];
                }
                if (bImage != null)
                {
                    pictureBox1.Image = new Bitmap(new MemoryStream(bImage));
                }
            }
        }

        private void img_upload(string person_id)
        {
            string qury = "";
            string strConn = "Server=192.168.0.23; Database=ppanam;UID=root;PASSWORD=1q2w3e4r;";
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            
            //MySqlDataReader rdr;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = qury;
            if (pictureBox1.Tag == null) { }
            else
            {
                FileStream fs = new FileStream(pictureBox1.Tag.ToString(), FileMode.Open, FileAccess.Read);
                byte[] bImage = new byte[fs.Length];
                fs.Read(bImage, 0, (int)fs.Length);
                qury = "SELECT COUNT(*) FROM influencer_tbl where person_id =" + person_id; 
                                                                      //qury = "SELECT COUNT(*) FROM IMAGE WHERE IMAGENO = 2";
                cmd.CommandText = qury;
                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result != 0)
                {
                    //qury = "UPDATE IMAGE SET IMAGE = :IMAGE WHERE IMAGENO = 2";
                    qury = "UPDATE influencer_tbl SET img = :img WHERE person_id = " + person_id;
                    cmd.CommandText = qury;
                    MySqlParameter param = cmd.Parameters.Add("img", MySqlDbType.Blob);
                    param.Value = bImage;
                    cmd.ExecuteNonQuery();
                    fs.Close();
                } 
                else
                {
                    //qury = "INSERT INTO IMAGE VALUES(" + ID + " , :사진 )";
                    //qury = "INSERT INTO IMAGE VALUES(2 , :IMAGE )";
                } 
            }
        }

        private void Pic_uplo_btn_Click(object sender, EventArgs e)
        {
            pic_file();
        }

        private void Mod_btn_Click(object sender, EventArgs e)
        {
            Modify_Mode();
        }

        private void Up_btn_Click(object sender, EventArgs e)
        {
            Readonly_Mode();
        }
    }
}
