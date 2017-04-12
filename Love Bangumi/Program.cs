using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Love_Bangumi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());

            //新建Login窗口
            LoginForm logForm = new LoginForm();

            //使用模式对话框方法显示logForm
            logForm.ShowDialog();

            //DialogResult就是用来判断是否返回父窗体的
            if (logForm.DialogResult == DialogResult.OK)
            {
                //在线程中打开主窗体 MainPanel
                Application.Run(new MainPanel());
            }
        }
    }
}
