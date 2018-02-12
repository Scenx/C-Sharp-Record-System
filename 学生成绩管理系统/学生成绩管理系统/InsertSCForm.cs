using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生成绩管理系统
{
    public partial class InsertSCForm : Form
    {
        public InsertSCForm()
        {
            InitializeComponent();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            String sno=textBox_sno.Text.Trim();
            String cno=textBox_cno.Text.Trim();
            String cgrade=textBox_cgrade.Text.Trim();
            if (sno.Equals("") || cno.Equals("") || cgrade.Equals(""))
            {
                MessageBox.Show("学号、课程号、成绩都不能为空！");
                return;
            }
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=localhost;Initial Catalog=学生成绩管理数据库;Persist Security Info=True;User ID=renzhenhua;Password=123456");
                conn.Open();
                string sql = "insert into sc(sno,cno,cgrade) values('" + sno + "','" + cno + "','" + cgrade + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    MessageBox.Show("录入成功！");
                }
                else
                {
                    MessageBox.Show("录入失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
