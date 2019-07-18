namespace ppanam
{
    partial class tester_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.product_name_box = new System.Windows.Forms.TextBox();
            this.company_name_box = new System.Windows.Forms.TextBox();
            this.Client_group = new System.Windows.Forms.GroupBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.write_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.req_box = new System.Windows.Forms.RichTextBox();
            this.Media_group = new System.Windows.Forms.GroupBox();
            this.blog_ck_box = new System.Windows.Forms.CheckBox();
            this.youtube_ck_box = new System.Windows.Forms.CheckBox();
            this.instagram_ck_box = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantity_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tester_project_grid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ambassador_ck_box = new System.Windows.Forms.CheckBox();
            this.tester_ck_box = new System.Windows.Forms.CheckBox();
            this.influencer_ck_box = new System.Windows.Forms.CheckBox();
            this.period_box = new System.Windows.Forms.TextBox();
            this.Client_group.SuspendLayout();
            this.Media_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tester_project_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Resgistrate";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // product_name_box
            // 
            this.product_name_box.Location = new System.Drawing.Point(134, 30);
            this.product_name_box.Name = "product_name_box";
            this.product_name_box.Size = new System.Drawing.Size(188, 25);
            this.product_name_box.TabIndex = 1;
            // 
            // company_name_box
            // 
            this.company_name_box.Location = new System.Drawing.Point(134, 61);
            this.company_name_box.Name = "company_name_box";
            this.company_name_box.Size = new System.Drawing.Size(188, 25);
            this.company_name_box.TabIndex = 2;
            // 
            // Client_group
            // 
            this.Client_group.Controls.Add(this.groupBox3);
            this.Client_group.Controls.Add(this.clear_btn);
            this.Client_group.Controls.Add(this.write_btn);
            this.Client_group.Controls.Add(this.label8);
            this.Client_group.Controls.Add(this.req_box);
            this.Client_group.Controls.Add(this.Media_group);
            this.Client_group.Controls.Add(this.label6);
            this.Client_group.Controls.Add(this.period_box);
            this.Client_group.Controls.Add(this.quantity_box);
            this.Client_group.Controls.Add(this.label5);
            this.Client_group.Controls.Add(this.label4);
            this.Client_group.Controls.Add(this.label3);
            this.Client_group.Controls.Add(this.company_name_box);
            this.Client_group.Controls.Add(this.product_name_box);
            this.Client_group.Location = new System.Drawing.Point(23, 95);
            this.Client_group.Name = "Client_group";
            this.Client_group.Size = new System.Drawing.Size(333, 513);
            this.Client_group.TabIndex = 14;
            this.Client_group.TabStop = false;
            this.Client_group.Text = "Client Infomation";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(9, 466);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(126, 39);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // write_btn
            // 
            this.write_btn.Location = new System.Drawing.Point(201, 466);
            this.write_btn.Name = "write_btn";
            this.write_btn.Size = new System.Drawing.Size(126, 40);
            this.write_btn.TabIndex = 10;
            this.write_btn.Text = "Write";
            this.write_btn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Client Requirement :";
            // 
            // req_box
            // 
            this.req_box.BackColor = System.Drawing.SystemColors.Window;
            this.req_box.Location = new System.Drawing.Point(9, 296);
            this.req_box.Name = "req_box";
            this.req_box.Size = new System.Drawing.Size(313, 164);
            this.req_box.TabIndex = 8;
            this.req_box.Text = "";
            // 
            // Media_group
            // 
            this.Media_group.Controls.Add(this.blog_ck_box);
            this.Media_group.Controls.Add(this.youtube_ck_box);
            this.Media_group.Controls.Add(this.instagram_ck_box);
            this.Media_group.Location = new System.Drawing.Point(9, 154);
            this.Media_group.Name = "Media_group";
            this.Media_group.Size = new System.Drawing.Size(106, 121);
            this.Media_group.TabIndex = 19;
            this.Media_group.TabStop = false;
            this.Media_group.Text = "Media";
            // 
            // blog_ck_box
            // 
            this.blog_ck_box.AutoSize = true;
            this.blog_ck_box.Location = new System.Drawing.Point(6, 96);
            this.blog_ck_box.Name = "blog_ck_box";
            this.blog_ck_box.Size = new System.Drawing.Size(59, 19);
            this.blog_ck_box.TabIndex = 7;
            this.blog_ck_box.Text = "Blog";
            this.blog_ck_box.UseVisualStyleBackColor = true;
            // 
            // youtube_ck_box
            // 
            this.youtube_ck_box.AutoSize = true;
            this.youtube_ck_box.Location = new System.Drawing.Point(6, 58);
            this.youtube_ck_box.Name = "youtube_ck_box";
            this.youtube_ck_box.Size = new System.Drawing.Size(82, 19);
            this.youtube_ck_box.TabIndex = 6;
            this.youtube_ck_box.Text = "Youtube";
            this.youtube_ck_box.UseVisualStyleBackColor = true;
            // 
            // instagram_ck_box
            // 
            this.instagram_ck_box.AutoSize = true;
            this.instagram_ck_box.Location = new System.Drawing.Point(6, 22);
            this.instagram_ck_box.Name = "instagram_ck_box";
            this.instagram_ck_box.Size = new System.Drawing.Size(91, 19);
            this.instagram_ck_box.TabIndex = 5;
            this.instagram_ck_box.Text = "Instagram";
            this.instagram_ck_box.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Projcet Period(Week) :";
            // 
            // quantity_box
            // 
            this.quantity_box.Location = new System.Drawing.Point(134, 92);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(188, 25);
            this.quantity_box.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Company Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product Name :";
            // 
            // tester_project_grid
            // 
            this.tester_project_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tester_project_grid.Location = new System.Drawing.Point(6, 24);
            this.tester_project_grid.Name = "tester_project_grid";
            this.tester_project_grid.RowHeadersWidth = 51;
            this.tester_project_grid.RowTemplate.Height = 27;
            this.tester_project_grid.Size = new System.Drawing.Size(567, 435);
            this.tester_project_grid.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.reset_btn);
            this.groupBox1.Controls.Add(this.tester_project_grid);
            this.groupBox1.Location = new System.Drawing.Point(389, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 513);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project List";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(6, 466);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(126, 39);
            this.delete_btn.TabIndex = 12;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(447, 465);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(126, 40);
            this.reset_btn.TabIndex = 13;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.influencer_ck_box);
            this.groupBox3.Controls.Add(this.ambassador_ck_box);
            this.groupBox3.Controls.Add(this.tester_ck_box);
            this.groupBox3.Location = new System.Drawing.Point(134, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 121);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // ambassador_ck_box
            // 
            this.ambassador_ck_box.AutoSize = true;
            this.ambassador_ck_box.Location = new System.Drawing.Point(6, 58);
            this.ambassador_ck_box.Name = "ambassador_ck_box";
            this.ambassador_ck_box.Size = new System.Drawing.Size(110, 19);
            this.ambassador_ck_box.TabIndex = 1;
            this.ambassador_ck_box.Text = "Ambassador";
            this.ambassador_ck_box.UseVisualStyleBackColor = true;
            // 
            // tester_ck_box
            // 
            this.tester_ck_box.AutoSize = true;
            this.tester_ck_box.Location = new System.Drawing.Point(6, 22);
            this.tester_ck_box.Name = "tester_ck_box";
            this.tester_ck_box.Size = new System.Drawing.Size(69, 19);
            this.tester_ck_box.TabIndex = 0;
            this.tester_ck_box.Text = "Tester";
            this.tester_ck_box.UseVisualStyleBackColor = true;
            // 
            // influencer_ck_box
            // 
            this.influencer_ck_box.AutoSize = true;
            this.influencer_ck_box.Location = new System.Drawing.Point(6, 96);
            this.influencer_ck_box.Name = "influencer_ck_box";
            this.influencer_ck_box.Size = new System.Drawing.Size(91, 19);
            this.influencer_ck_box.TabIndex = 2;
            this.influencer_ck_box.Text = "Influencer";
            this.influencer_ck_box.UseVisualStyleBackColor = true;
            // 
            // period_box
            // 
            this.period_box.Location = new System.Drawing.Point(260, 123);
            this.period_box.Name = "period_box";
            this.period_box.Size = new System.Drawing.Size(62, 25);
            this.period_box.TabIndex = 4;
            // 
            // tester_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 620);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Client_group);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tester_form";
            this.Text = "tester_form";
            this.Client_group.ResumeLayout(false);
            this.Client_group.PerformLayout();
            this.Media_group.ResumeLayout(false);
            this.Media_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tester_project_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_name_box;
        private System.Windows.Forms.TextBox company_name_box;
        private System.Windows.Forms.GroupBox Client_group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox req_box;
        private System.Windows.Forms.GroupBox Media_group;
        private System.Windows.Forms.CheckBox blog_ck_box;
        private System.Windows.Forms.CheckBox youtube_ck_box;
        private System.Windows.Forms.CheckBox instagram_ck_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantity_box;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button write_btn;
        private System.Windows.Forms.DataGridView tester_project_grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox influencer_ck_box;
        private System.Windows.Forms.CheckBox ambassador_ck_box;
        private System.Windows.Forms.CheckBox tester_ck_box;
        private System.Windows.Forms.TextBox period_box;
    }
}