using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm_gh26032021
{
    public partial class FormConfig : Form
    {
        ControlAction controlAction = new ControlAction();
        public FormConfig()
        {
            InitializeComponent();
        }

        private void cboSN_DropDown(object sender, EventArgs e)
        {
            cboSN.DataSource = controlAction.getServerName();
            cboSN.DisplayMember = "ServerName";
        }

        private void cboDB_DropDown(object sender, EventArgs e)
        {
            if(txtPW.Text.Trim().Count() == 0 || txtUN.Text.Trim().Count() == 0)
            {
                MessageBox.Show("Username or password is empty");
                return;
            }
            DataTable dt = controlAction.getDataBase(cboSN.Text.Trim(), txtUN.Text.Trim(), txtPW.Text.Trim());
            if (dt == null)
            {
                MessageBox.Show("Something wrong!!");
                return;
            }
            cboDB.DataSource = dt;
            cboDB.DisplayMember = "name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(this,"Do you want to exit the program? ", "Close Program",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                Program.formConfig.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control con in Controls)
            {
                if(con.GetType() == typeof(TextBox) || con.GetType() == typeof(ComboBox))
                {
                    if (con.Text.Equals(""))
                    {
                        MessageBox.Show("Please fill in all textbox!!");
                        txtUN.Focus();
                        break;
                    }
                }
            }

        }
    }
}
