namespace ppanam
{
    partial class process_form
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
            this.IGTV_tab = new System.Windows.Forms.TabPage();
            this.Tester_tab = new System.Windows.Forms.TabPage();
            this.Process_tabs = new System.Windows.Forms.TabControl();
            this.Youtube_tab = new System.Windows.Forms.TabPage();
            this.Process_tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process";
            // 
            // IGTV_tab
            // 
            this.IGTV_tab.Location = new System.Drawing.Point(4, 22);
            this.IGTV_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IGTV_tab.Name = "IGTV_tab";
            this.IGTV_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IGTV_tab.Size = new System.Drawing.Size(828, 426);
            this.IGTV_tab.TabIndex = 1;
            this.IGTV_tab.Text = "IGTV";
            this.IGTV_tab.UseVisualStyleBackColor = true;
            // 
            // Tester_tab
            // 
            this.Tester_tab.Location = new System.Drawing.Point(4, 22);
            this.Tester_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tester_tab.Name = "Tester_tab";
            this.Tester_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tester_tab.Size = new System.Drawing.Size(828, 426);
            this.Tester_tab.TabIndex = 0;
            this.Tester_tab.Text = "Tester";
            this.Tester_tab.UseVisualStyleBackColor = true;
            // 
            // Process_tabs
            // 
            this.Process_tabs.Controls.Add(this.Tester_tab);
            this.Process_tabs.Controls.Add(this.IGTV_tab);
            this.Process_tabs.Controls.Add(this.Youtube_tab);
            this.Process_tabs.Location = new System.Drawing.Point(11, 34);
            this.Process_tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Process_tabs.Name = "Process_tabs";
            this.Process_tabs.SelectedIndex = 0;
            this.Process_tabs.Size = new System.Drawing.Size(836, 452);
            this.Process_tabs.TabIndex = 1;
            // 
            // Youtube_tab
            // 
            this.Youtube_tab.Location = new System.Drawing.Point(4, 22);
            this.Youtube_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Youtube_tab.Name = "Youtube_tab";
            this.Youtube_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Youtube_tab.Size = new System.Drawing.Size(828, 426);
            this.Youtube_tab.TabIndex = 2;
            this.Youtube_tab.Text = "Youtube";
            this.Youtube_tab.UseVisualStyleBackColor = true;
            // 
            // process_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.Process_tabs);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "process_form";
            this.Text = "process_form";
            this.Process_tabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage IGTV_tab;
        private System.Windows.Forms.TabPage Tester_tab;
        private System.Windows.Forms.TabControl Process_tabs;
        private System.Windows.Forms.TabPage Youtube_tab;
    }
}