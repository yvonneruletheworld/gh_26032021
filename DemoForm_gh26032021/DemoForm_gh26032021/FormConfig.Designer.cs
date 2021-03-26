namespace DemoForm_gh26032021
{
    partial class FormConfig
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSN = new System.Windows.Forms.ComboBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Database";
            // 
            // cboDB
            // 
            this.cboDB.FormattingEnabled = true;
            this.cboDB.Location = new System.Drawing.Point(247, 187);
            this.cboDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDB.Name = "cboDB";
            this.cboDB.Size = new System.Drawing.Size(222, 28);
            this.cboDB.TabIndex = 17;
            this.cboDB.DropDown += new System.EventHandler(this.cboDB_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(247, 134);
            this.txtPW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(222, 26);
            this.txtPW.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "User name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server name";
            // 
            // cboSN
            // 
            this.cboSN.FormattingEnabled = true;
            this.cboSN.Location = new System.Drawing.Point(247, 17);
            this.cboSN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSN.Name = "cboSN";
            this.cboSN.Size = new System.Drawing.Size(222, 28);
            this.cboSN.TabIndex = 11;
            this.cboSN.DropDown += new System.EventHandler(this.cboSN_DropDown);
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(247, 74);
            this.txtUN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(222, 26);
            this.txtUN.TabIndex = 10;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 320);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSN);
            this.Controls.Add(this.txtUN);
            this.Name = "FormConfig";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSN;
        private System.Windows.Forms.TextBox txtUN;
    }
}

