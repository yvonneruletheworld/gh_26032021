namespace DemoForm_gh26032021
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLyNguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamCongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyNguoiDungToolStripMenuItem,
            this.nhanSuToolStripMenuItem,
            this.chamCongToolStripMenuItem,
            this.tinhLuongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyNguoiDungToolStripMenuItem
            // 
            this.quanLyNguoiDungToolStripMenuItem.Name = "quanLyNguoiDungToolStripMenuItem";
            this.quanLyNguoiDungToolStripMenuItem.Size = new System.Drawing.Size(187, 32);
            this.quanLyNguoiDungToolStripMenuItem.Text = "Quan ly nguoi dung";
            // 
            // nhanSuToolStripMenuItem
            // 
            this.nhanSuToolStripMenuItem.Name = "nhanSuToolStripMenuItem";
            this.nhanSuToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.nhanSuToolStripMenuItem.Text = "Nhan su";
            // 
            // chamCongToolStripMenuItem
            // 
            this.chamCongToolStripMenuItem.Name = "chamCongToolStripMenuItem";
            this.chamCongToolStripMenuItem.Size = new System.Drawing.Size(119, 32);
            this.chamCongToolStripMenuItem.Text = "Cham cong";
            // 
            // tinhLuongToolStripMenuItem
            // 
            this.tinhLuongToolStripMenuItem.Name = "tinhLuongToolStripMenuItem";
            this.tinhLuongToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.tinhLuongToolStripMenuItem.Text = "Tinh luong";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(650, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 25);
            this.toolStripStatusLabel1.Text = "User";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 320);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyNguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamCongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhLuongToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}