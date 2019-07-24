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
            this.create_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pic_uplo_btn = new System.Windows.Forms.Button();
            this.ans_box = new System.Windows.Forms.ComboBox();
            this.status_box = new System.Windows.Forms.ComboBox();
            this.orient_box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.emali_box = new System.Windows.Forms.TextBox();
            this.blog_box = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tester_tblTableAdapter1 = new ppanam.ppanamDataSetTableAdapters.tester_tblTableAdapter();
            this.black_ch_box = new System.Windows.Forms.CheckBox();
            this.p_box = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kunstler Script", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 42);
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
            this.influ_list.Location = new System.Drawing.Point(6, 20);
            this.influ_list.MultiSelect = false;
            this.influ_list.Name = "influ_list";
            this.influ_list.Size = new System.Drawing.Size(214, 323);
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
            this.groupBox1.Controls.Add(this.create_btn);
            this.groupBox1.Controls.Add(this.mod_btn);
            this.groupBox1.Controls.Add(this.reset_btn);
            this.groupBox1.Controls.Add(this.influ_list);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 419);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Influencer List";
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(81, 349);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(63, 44);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            // 
            // mod_btn
            // 
            this.mod_btn.Location = new System.Drawing.Point(157, 349);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(63, 44);
            this.mod_btn.TabIndex = 4;
            this.mod_btn.Text = "Modify";
            this.mod_btn.UseVisualStyleBackColor = true;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(6, 349);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(63, 44);
            this.reset_btn.TabIndex = 3;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.p_box);
            this.groupBox2.Controls.Add(this.black_ch_box);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.pic_uplo_btn);
            this.groupBox2.Controls.Add(this.ans_box);
            this.groupBox2.Controls.Add(this.status_box);
            this.groupBox2.Controls.Add(this.orient_box);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.emali_box);
            this.groupBox2.Controls.Add(this.blog_box);
            this.groupBox2.Controls.Add(this.label12);
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
            this.groupBox2.Location = new System.Drawing.Point(245, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 240);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
            // 
            // pic_uplo_btn
            // 
            this.pic_uplo_btn.Location = new System.Drawing.Point(7, 193);
            this.pic_uplo_btn.Name = "pic_uplo_btn";
            this.pic_uplo_btn.Size = new System.Drawing.Size(159, 23);
            this.pic_uplo_btn.TabIndex = 13;
            this.pic_uplo_btn.Text = "Upload";
            this.pic_uplo_btn.UseVisualStyleBackColor = true;
            this.pic_uplo_btn.Visible = false;
            // 
            // ans_box
            // 
            this.ans_box.FormattingEnabled = true;
            this.ans_box.Location = new System.Drawing.Point(496, 187);
            this.ans_box.Name = "ans_box";
            this.ans_box.Size = new System.Drawing.Size(89, 20);
            this.ans_box.TabIndex = 12;
            // 
            // status_box
            // 
            this.status_box.FormattingEnabled = true;
            this.status_box.Items.AddRange(new object[] {
            "Connect",
            "To be connected",
            "Not Connect"});
            this.status_box.Location = new System.Drawing.Point(254, 187);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(106, 20);
            this.status_box.TabIndex = 11;
            // 
            // orient_box
            // 
            this.orient_box.Location = new System.Drawing.Point(254, 154);
            this.orient_box.Name = "orient_box";
            this.orient_box.Size = new System.Drawing.Size(249, 21);
            this.orient_box.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(416, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "Answer :";
            // 
            // emali_box
            // 
            this.emali_box.Location = new System.Drawing.Point(254, 127);
            this.emali_box.Name = "emali_box";
            this.emali_box.Size = new System.Drawing.Size(249, 21);
            this.emali_box.TabIndex = 5;
            // 
            // blog_box
            // 
            this.blog_box.Location = new System.Drawing.Point(254, 100);
            this.blog_box.Name = "blog_box";
            this.blog_box.Size = new System.Drawing.Size(249, 21);
            this.blog_box.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "Orientation :";
            // 
            // subs_box
            // 
            this.subs_box.Location = new System.Drawing.Point(496, 73);
            this.subs_box.Name = "subs_box";
            this.subs_box.Size = new System.Drawing.Size(89, 21);
            this.subs_box.TabIndex = 0;
            // 
            // Insta_box
            // 
            this.Insta_box.Location = new System.Drawing.Point(254, 46);
            this.Insta_box.Name = "Insta_box";
            this.Insta_box.Size = new System.Drawing.Size(151, 21);
            this.Insta_box.TabIndex = 0;
            // 
            // you_box
            // 
            this.you_box.Location = new System.Drawing.Point(254, 73);
            this.you_box.Name = "you_box";
            this.you_box.Size = new System.Drawing.Size(151, 21);
            this.you_box.TabIndex = 0;
            // 
            // foll_box
            // 
            this.foll_box.Location = new System.Drawing.Point(496, 46);
            this.foll_box.Name = "foll_box";
            this.foll_box.Size = new System.Drawing.Size(89, 21);
            this.foll_box.TabIndex = 0;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(254, 20);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(151, 21);
            this.name_box.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "Follower :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Subscriber :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Youtube :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Blog :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Instagram :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(245, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 173);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project Log";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 167);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tester_tblTableAdapter1
            // 
            this.tester_tblTableAdapter1.ClearBeforeFill = true;
            // 
            // black_ch_box
            // 
            this.black_ch_box.AutoSize = true;
            this.black_ch_box.Location = new System.Drawing.Point(496, 20);
            this.black_ch_box.Name = "black_ch_box";
            this.black_ch_box.Size = new System.Drawing.Size(75, 16);
            this.black_ch_box.TabIndex = 15;
            this.black_ch_box.Text = "Black list";
            this.black_ch_box.UseVisualStyleBackColor = true;
            // 
            // p_box
            // 
            this.p_box.Location = new System.Drawing.Point(254, 213);
            this.p_box.Name = "p_box";
            this.p_box.Size = new System.Drawing.Size(331, 21);
            this.p_box.TabIndex = 16;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(589, 133);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 12);
            this.label12.TabIndex = 9;
            this.label12.Text = "Project :";
            // 
            // influencer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "influencer_form";
            this.Text = "influencer_form";
            this.Load += new System.EventHandler(this.Influencer_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ListView listView1;
    }
}