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
    public partial class UpdateSCForm : Form
    {
        public UpdateSCForm()
        {
            InitializeComponent();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            String sno = textBox_sno.Text.Trim();
            String cno = textBox_cno.Text.Trim();
            if (sno.Equals("") || cno.Equals(""))
            {
                MessageBox.Show("学号、课程号都不能为空！");
                return;
            }
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=localhost;Initial Catalog=学生成绩管理数据库;Persist Security Info=True;User ID=renzhenhua;Password=123456");
                conn.Open();
                string sql = "select * from sc where sno='"+sno+"' and cno='"+cno+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr=cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox_sno.Text = dr["sno"].ToString();
                    textBox_cno.Text = dr["cno"].ToString();
                    textBox_cgrade.Text = dr["cgrade"].ToString();
                }
                else
                {
                    MessageBox.Show("未查询到该学号、课程号对应的记录！");
                    textBox_cgrade.Text = "";
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

        private void button_update_Click(object sender, EventArgs e)
        {
            String sno = textBox_sno.Text.Trim();
            String cno = textBox_cno.Text.Trim();
            String cgrade = textBox_cgrade.Text.Trim();
            if (sno.Equals("") || cno.Equals(""))
            {
                MessageBox.Show("学号、课程号都不能为空！");
                return;
            }
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=学生成绩管理数据库;Persist Security Info=True;User ID=renzhenhua;Password=123456");
                conn.Open();
                string sql = "update sc set cgrade='"+cgrade+"' where sno='" + sno + "' and cno='" + cno + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    MessageBox.Show("更新失败！");
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
