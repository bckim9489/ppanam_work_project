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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 70);
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
            this.groupBox1.Location = new System.Drawing.Point(14, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(258, 524);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Influencer List";
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
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(7, 436);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(72, 55);
            this.reset_btn.TabIndex = 3;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(280, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(687, 274);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail";
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
            // 
            // ans_box
            // 
            this.ans_box.FormattingEnabled = true;
            this.ans_box.Location = new System.Drawing.Point(504, 234);
            this.ans_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ans_box.Name = "ans_box";
            this.ans_box.Size = new System.Drawing.Size(138, 23);
            this.ans_box.TabIndex = 12;
            // 
            // status_box
            // 
            this.status_box.FormattingEnabled = true;
            this.status_box.Location = new System.Drawing.Point(285, 234);
            this.status_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(126, 23);
            this.status_box.TabIndex = 11;
            // 
            // orient_box
            // 
            this.orient_box.Location = new System.Drawing.Point(290, 192);
            this.orient_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orient_box.Name = "orient_box";
            this.orient_box.Size = new System.Drawing.Size(284, 25);
            this.orient_box.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(433, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Answer :";
            // 
            // emali_box
            // 
            this.emali_box.Location = new System.Drawing.Point(285, 159);
            this.emali_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emali_box.Name = "emali_box";
            this.emali_box.Size = new System.Drawing.Size(172, 25);
            this.emali_box.TabIndex = 5;
            // 
            // blog_box
            // 
            this.blog_box.Location = new System.Drawing.Point(285, 125);
            this.blog_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.blog_box.Name = "blog_box";
            this.blog_box.Size = new System.Drawing.Size(172, 25);
            this.blog_box.TabIndex = 6;
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
            this.subs_box.Location = new System.Drawing.Point(582, 91);
            this.subs_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subs_box.Name = "subs_box";
            this.subs_box.Size = new System.Drawing.Size(101, 25);
            this.subs_box.TabIndex = 0;
            // 
            // Insta_box
            // 
            this.Insta_box.Location = new System.Drawing.Point(285, 58);
            this.Insta_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insta_box.Name = "Insta_box";
            this.Insta_box.Size = new System.Drawing.Size(172, 25);
            this.Insta_box.TabIndex = 0;
            // 
            // you_box
            // 
            this.you_box.Location = new System.Drawing.Point(285, 91);
            this.you_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.you_box.Name = "you_box";
            this.you_box.Size = new System.Drawing.Size(172, 25);
            this.you_box.TabIndex = 0;
            // 
            // foll_box
            // 
            this.foll_box.Location = new System.Drawing.Point(582, 58);
            this.foll_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.foll_box.Name = "foll_box";
            this.foll_box.Size = new System.Drawing.Size(101, 25);
            this.foll_box.TabIndex = 0;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(261, 25);
            this.name_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(196, 25);
            this.name_box.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Follower :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 95);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(280, 362);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(687, 242);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Project Log";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(8, 25);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(551, 209);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // influencer_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 620);
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
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.ListView listView1;
    }
}