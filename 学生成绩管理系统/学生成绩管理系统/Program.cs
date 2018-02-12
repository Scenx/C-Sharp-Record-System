using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 学生成绩管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm frm = new LoginForm();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            
        }
    }
}
