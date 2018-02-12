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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username = textBox_username.Text.Trim();
            String password = textBox_password.Text.Trim();
            int usertype = 0;
            if (radioButton_user.Checked)
            {
                usertype = 0;
            }
            else
            {
                usertype = 1;
            }
            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
                return;
            }

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=localhost;Initial Catalog=学生成绩管理数据库;Persist Security Info=True;User ID=renzhenhua;Password=123456");
                conn.Open();
                string sql = "select * from myuser where username='" + username + "' and password='"+password+"' and usertype="+usertype;
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader dr=cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserInfo.username = username;
                    UserInfo.usertype = usertype;

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！");
                    textBox_username.Text = "";
                    textBox_password.Text = "";
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
