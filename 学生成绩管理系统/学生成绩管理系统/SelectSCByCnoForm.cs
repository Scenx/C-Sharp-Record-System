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
    public partial class SelectSCByCnoForm : Form
    {
        public SelectSCByCnoForm()
        {
            InitializeComponent();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            String cno = textBox_cno.Text.Trim();
            if (cno.Equals("") || cno.Length < 1)
            {
                MessageBox.Show("课程号不能为空！");
                return;
            }
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=localhost;Initial Catalog=学生成绩管理数据库;Persist Security Info=True;User ID=renzhenhua;Password=123456");
                conn.Open();
                string sql = "select * from sc where cno='" + cno + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                label_msg.Text = "共查询到" + ds.Tables[0].Rows.Count + "条符合条件的记录！";
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
