using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;

namespace RX_DataUpdata
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
            ULogin uLogin = new ULogin();
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            bool RunAdmin = identity != null && new WindowsPrincipal(identity).IsInRole(WindowsBuiltInRole.Administrator);
            if(!RunAdmin)
            {
                try
                {
                    Process.Start(new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase) { UseShellExecute = true, Verb = "runs" });
                }
                catch (Exception)
                {

                    //MessageBox.Show(string.Format("以管理员方式启动失败，将尝试以普通方式启动！{0}{1}", Environment.NewLine, ex), "出错啦！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // run();//以管理员方式启动失败，则尝试普通方式启动
                    MessageBox.Show("管理员运行失败");
                }
            }
            uLogin.ShowDialog();
            if (uLogin.DialogResult == DialogResult.Yes)
            {
                MSDDataContext mSDData = new MSDDataContext();
                try
                {
                    RXYF_YECCDataSetTableAdapters.QueriesTableAdapter adapter = new RXYF_YECCDataSetTableAdapters.QueriesTableAdapter();
                    adapter.ServerIPSerch(ref SysVar.SIP, ref SysVar.SName, ref SysVar.ClientIP);
                }
                catch (Exception)
                {

                    throw;
                }
                Application.Run(new Main());
            }
        }
    }
}
