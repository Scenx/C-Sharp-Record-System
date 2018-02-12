using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生成绩管理系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            InsertSCForm frm = new InsertSCForm();
            frm.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            UpdateSCForm frm = new UpdateSCForm();
            frm.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DeleteSCForm frm = new DeleteSCForm();
            frm.Show();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            SelectSCBySnoForm frm = new SelectSCBySnoForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectSCByCnoForm frm = new SelectSCByCnoForm();
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (UserInfo.usertype == 0)
            {
                button_insert.Enabled = false;
                button_update.Enabled = false;
                button_delete.Enabled = false;
            }
            else
            { 
                
            }
        }
    }
}
