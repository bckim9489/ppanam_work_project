namespace ppanam
{
    partial class influencer_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.influ_list = new System.Windows.Forms.ListView();
            this.pid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addr_box = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.type_Box = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.person_id_lb = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.p_box = new System.Windows.Forms.TextBox();
            this.black_ch_box = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_uplo_btn = new System.Windows.Forms.Button();
            this.ans_box = new System.Windows.Forms.ComboBox();
            this.status_box = new System.Windows.Forms.ComboBox();
            this.orient_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.emali_box = new System.Windows.Forms.TextBox();
            this.blog_box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.subs_box = new System.Windows.Forms.TextBox();
            this.Insta_box = new System.Windows.Forms.TextBox();
            this.you_box = new System.Windows.Forms.TextBox();
            this.foll_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.plog_view = new System.Windows.Forms.ListView();
            this.tester_tblTableAdapter1 = new ppanam.ppanamDataSetTableAdapters.tester_tblTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kunstler Script", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Influencer";
            // 
            // influ_list
            // 
            this.influ_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pid,
            this.name});
            this.influ_list.FullRowSelect = true;
            this.influ_list.GridLines = true;
            this.influ_list.Location = new System.Drawing.Point(7, 25);
            this.influ_list.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.influ_list.MultiSelect = false;
            this.influ_list.Name = "influ_list";
            this.influ_list.Size = new System.Drawing.Size(244, 403);
            this.influ_list.TabIndex = 2;
            this.influ_list.UseCompatibleStateImageBehavior = false;
            this.influ_list.View = System.Windows.Forms.View.Details;
            this.influ_list.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.Influ_list_ItemSelectionChanged);
            // 
            // pid
            // 
            this.pid.Text = "PID";
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 180;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.del_btn);
            this.groupBox1.Controls.Add(this.up_btn);
            this.groupBox1.Controls.Add(this.create_btn);
            this.groupBox1.Controls.Add(this.mod_btn);
            this.groupBox1.Controls.Add(this.influ_list);
            this.groupBox1.Location = new System.Drawing.Point(14, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(258, 524);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Influencer List";
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(7, 436);
            this.del_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(72, 55);
            this.del_btn.TabIndex = 16;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // up_btn
            // 
            this.up_btn.Location = new System.Drawing.Point(180, 436);
            this.up_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(72, 55);
            this.up_btn.TabIndex = 6;
            this.up_btn.Text = "Update";
            this.up_btn.UseVisualStyleBackColor = true;
            this.up_btn.Visible = false;
            this.up_btn.Click += new System.EventHandler(this.Up_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(93, 436);
            this.create_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(72, 55);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // mod_btn
            // 
            this.mod_btn.Location = new System.Drawing.Point(179, 436);
            this.mod_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(72, 55);
            this.mod_btn.TabIndex = 4;
            this.mod_btn.Text = "Modify";
            this.mod_btn.UseVisualStyleBackColor = true;
            this.mod_btn.Click += new System.EventHandler(this.Mod_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(888, 15);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(72, 26);
            this.reset_btn.TabIndex = 3;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addr_box);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.type_Box);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.person_id_lb);
            this.groupBox2.Controls.Add(this.p_box);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.black_ch_box);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pic_uplo_btn);
            this.groupBox2.Controls.Add(this.ans_box);
            this.groupBox2.Controls.Add(this.status_box);
            this.groupBox2.Controls.Add(this.orient_box);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.emali_box);
            this.groupBox2.Controls.Add(this.blog_box);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.subs_box);
            this.groupBox2.Controls.Add(this.Insta_box);
            this.groupBox2.Controls.Add(this.you_box);
            this.groupBox2.Controls.Add(this.foll_box);
            this.groupBox2.Controls.Add(this.name_box);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(280, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(687, 335);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // addr_box
            // 
            this.addr_box.Location = new System.Drawing.Point(290, 269);
            this.addr_box.Name = "addr_box";
            this.addr_box.Size = new System.Drawing.Size(378, 25);
            this.addr_box.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(200, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "Address : ";
            // 
            // type_Box
            // 
            this.type_Box.FormattingEnabled = true;
            this.type_Box.Items.AddRange(new object[] {
            "Tester",
            "Ambassador",
            "Influencer"});
            this.type_Box.Location = new System.Drawing.Point(502, 234);
            this.type_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.type_Box.Name = "type_Box";
            this.type_Box.Size = new System.Drawing.Size(166, 23);
            this.type_Box.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(447, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Type :";
            // 
            // person_id_lb
            // 
            this.person_id_lb.AutoSize = true;
            this.person_id_lb.Location = new System.Drawing.Point(42, 276);
            this.person_id_lb.Name = "person_id_lb";
            this.person_id_lb.Size = new System.Drawing.Size(15, 15);
            this.person_id_lb.TabIndex = 17;
            this.person_id_lb.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "ID :";
            // 
            // p_box
            // 
            this.p_box.Location = new System.Drawing.Point(290, 302);
            this.p_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.p_box.Name = "p_box";
            this.p_box.Size = new System.Drawing.Size(378, 25);
            this.p_box.TabIndex = 16;
            this.p_box.Text = " ";
            // 
            // black_ch_box
            // 
            this.black_ch_box.AutoSize = true;
            this.black_ch_box.Location = new System.Drawing.Point(102, 275);
            this.black_ch_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.black_ch_box.Name = "black_ch_box";
            this.black_ch_box.Size = new System.Drawing.Size(88, 19);
            this.black_ch_box.TabIndex = 15;
            this.black_ch_box.Text = "Black list";
            this.black_ch_box.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 209);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pic_uplo_btn
            // 
            this.pic_uplo_btn.Location = new System.Drawing.Point(8, 241);
            this.pic_uplo_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_uplo_btn.Name = "pic_uplo_btn";
            this.pic_uplo_btn.Size = new System.Drawing.Size(182, 29);
            this.pic_uplo_btn.TabIndex = 13;
            this.pic_uplo_btn.Text = "Upload";
            this.pic_uplo_btn.UseVisualStyleBackColor = true;
            this.pic_uplo_btn.Visible = false;
            this.pic_uplo_btn.Click += new System.EventHandler(this.Pic_uplo_btn_Click);
            // 
            // ans_box
            // 
            this.ans_box.FormattingEnabled = true;
            this.ans_box.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.ans_box.Location = new System.Drawing.Point(567, 22);
            this.ans_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ans_box.Name = "ans_box";
            this.ans_box.Size = new System.Drawing.Size(101, 23);
            this.ans_box.TabIndex = 12;
            // 
            // status_box
            // 
            this.status_box.FormattingEnabled = true;
            this.status_box.Items.AddRange(new object[] {
            "Connect",
            "To be connected",
            "Not Connect"});
            this.status_box.Location = new System.Drawing.Point(290, 234);
            this.status_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(121, 23);
            this.status_box.TabIndex = 11;
            // 
            // orient_box
            // 
            this.orient_box.Location = new System.Drawing.Point(290, 192);
            this.orient_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orient_box.Name = "orient_box";
            this.orient_box.Size = new System.Drawing.Size(378, 25);
            this.orient_box.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(475, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Answer :";
            // 
            // emali_box
            // 
            this.emali_box.Location = new System.Drawing.Point(290, 159);
            this.emali_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emali_box.Name = "emali_box";
            this.emali_box.Size = new System.Drawing.Size(378, 25);
            this.emali_box.TabIndex = 5;
            // 
            // blog_box
            // 
            this.blog_box.Location = new System.Drawing.Point(290, 125);
            this.blog_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blog_box.Name = "blog_box";
            this.blog_box.Size = new System.Drawing.Size(378, 25);
            this.blog_box.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Project :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Orientation :";
            // 
            // subs_box
            // 
            this.subs_box.Location = new System.Drawing.Point(567, 91);
            this.subs_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subs_box.Name = "subs_box";
            this.subs_box.Size = new System.Drawing.Size(101, 25);
            this.subs_box.TabIndex = 0;
            // 
            // Insta_box
            // 
            this.Insta_box.Location = new System.Drawing.Point(290, 58);
            this.Insta_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insta_box.Name = "Insta_box";
            this.Insta_box.Size = new System.Drawing.Size(172, 25);
            this.Insta_box.TabIndex = 0;
            // 
            // you_box
            // 
            this.you_box.Location = new System.Drawing.Point(290, 91);
            this.you_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.you_box.Name = "you_box";
            this.you_box.Size = new System.Drawing.Size(172, 25);
            this.you_box.TabIndex = 0;
            // 
            // foll_box
            // 
            this.foll_box.Location = new System.Drawing.Point(567, 58);
            this.foll_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.foll_box.Name = "foll_box";
            this.foll_box.Size = new System.Drawing.Size(101, 25);
            this.foll_box.TabIndex = 0;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(290, 25);
            this.name_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(172, 25);
            this.name_box.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Follower :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Subscriber :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Youtube :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Blog :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Instagram :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.plog_view);
            this.groupBox3.Location = new System.Drawing.Point(282, 424);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(687, 181);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project Log";
            // 
            // plog_view
            // 
            this.plog_view.Location = new System.Drawing.Point(6, 17);
            this.plog_view.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plog_view.Name = "plog_view";
            this.plog_view.Size = new System.Drawing.Size(673, 156);
            this.plog_view.TabIndex = 17;
            this.plog_view.UseCompatibleStateImageBehavior = false;
            this.plog_view.SelectedIndexChanged += new System.EventHandler(this.Plog_view_SelectedIndexChanged);
            // 
            // tester_tblTableAdapter1
            // 
            this.tester_tblTableAdapter1.ClearBeforeFill = true;
            // 
            // influencer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "influencer_form";
            this.Text = "influencer_form";
            this.Load += new System.EventHandler(this.Influencer_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView influ_list;
        private System.Windows.Forms.ColumnHeader pid;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox subs_box;
        private System.Windows.Forms.TextBox Insta_box;
        private System.Windows.Forms.TextBox you_box;
        private System.Windows.Forms.TextBox foll_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emali_box;
        private System.Windows.Forms.TextBox blog_box;
        private System.Windows.Forms.TextBox orient_box;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button pic_uplo_btn;
        private System.Windows.Forms.ComboBox ans_box;
        private System.Windows.Forms.ComboBox status_box;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ppanamDataSetTableAdapters.tester_tblTableAdapter tester_tblTableAdapter1;
        private System.Windows.Forms.CheckBox black_ch_box;
        private System.Windows.Forms.TextBox p_box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView plog_view;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Label person_id_lb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.ComboBox type_Box;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addr_box;
        private System.Windows.Forms.Label label15;
    }
}