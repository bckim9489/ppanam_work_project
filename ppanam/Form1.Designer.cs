namespace ppanam
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processWriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teskUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaUploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ppanamDataSet1 = new ppanam.ppanamDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppanamDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processWriteToolStripMenuItem,
            this.projectLoadToolStripMenuItem,
            this.modelToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // processWriteToolStripMenuItem
            // 
            this.processWriteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testerToolStripMenuItem});
            this.processWriteToolStripMenuItem.Name = "processWriteToolStripMenuItem";
            this.processWriteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.processWriteToolStripMenuItem.Text = "Project";
            // 
            // testerToolStripMenuItem
            // 
            this.testerToolStripMenuItem.Name = "testerToolStripMenuItem";
            this.testerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.testerToolStripMenuItem.Text = "Registrate";
            this.testerToolStripMenuItem.Click += new System.EventHandler(this.TesterToolStripMenuItem_Click);
            // 
            // projectLoadToolStripMenuItem
            // 
            this.projectLoadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolStripMenuItem,
            this.teskUpToolStripMenuItem,
            this.testerToolStripMenuItem1,
            this.deliveryToolStripMenuItem1,
            this.mediaUploadToolStripMenuItem});
            this.projectLoadToolStripMenuItem.Name = "projectLoadToolStripMenuItem";
            this.projectLoadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projectLoadToolStripMenuItem.Text = "Process";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusToolStripMenuItem.Text = "Show Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.StatusToolStripMenuItem_Click);
            // 
            // teskUpToolStripMenuItem
            // 
            this.teskUpToolStripMenuItem.Name = "teskUpToolStripMenuItem";
            this.teskUpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teskUpToolStripMenuItem.Text = "Influencer";
            this.teskUpToolStripMenuItem.Click += new System.EventHandler(this.TeskUpToolStripMenuItem_Click);
            // 
            // testerToolStripMenuItem1
            // 
            this.testerToolStripMenuItem1.Name = "testerToolStripMenuItem1";
            this.testerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.testerToolStripMenuItem1.Text = "Tester";
            this.testerToolStripMenuItem1.Click += new System.EventHandler(this.TesterToolStripMenuItem1_Click);
            // 
            // deliveryToolStripMenuItem1
            // 
            this.deliveryToolStripMenuItem1.Name = "deliveryToolStripMenuItem1";
            this.deliveryToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deliveryToolStripMenuItem1.Text = "Delivery";
            this.deliveryToolStripMenuItem1.Click += new System.EventHandler(this.DeliveryToolStripMenuItem1_Click);
            // 
            // mediaUploadToolStripMenuItem
            // 
            this.mediaUploadToolStripMenuItem.Name = "mediaUploadToolStripMenuItem";
            this.mediaUploadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mediaUploadToolStripMenuItem.Text = "Media Upload";
            this.mediaUploadToolStripMenuItem.Click += new System.EventHandler(this.MediaUploadToolStripMenuItem_Click);
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ppanamDataSet1
            // 
            this.ppanamDataSet1.DataSetName = "ppanamDataSet";
            this.ppanamDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(859, 522);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppanamDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processWriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectLoadToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ppanamDataSet ppanamDataSet1;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teskUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mediaUploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testerToolStripMenuItem1;
    }
}

