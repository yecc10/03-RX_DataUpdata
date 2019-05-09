using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Microsoft.AspNet.Identity;

namespace RX_DataUpdata
{
    /// <summary>
    ///自定义系统函数
    /// </summary>
    class SysVar
    {
        public static string UserName = string.Empty; //用户名存储
        public static string Pswd = string.Empty;//密码
        public static string Role = string.Empty;//角色
        public static int Acc = 0;  //权限控制 0 无任何权限 1-15 为普通功能预留权限16-999为特殊功能权限
        public static string SIP = string.Empty;  //服务器IP
        public static string SName = string.Empty;  //服务器名称
        public static string ClientIP = string.Empty;  //客户端IP
        public static string BackRemark = string.Empty;  //程序临时备份文件
    }
    class RegOprate
    {
        /// <summary>
        /// 注册表存在检查
        /// </summary>
        /// <param name="name">待确认的注册表名称</param>
        /// <returns></returns>
       static public bool IsRegeditExit(string name)
        {
            bool _exit = false;
            string[] subkeyName;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
            RegistryKey admindir = software.OpenSubKey("RXYFYECHAOCHENG", true);
            if (admindir==null)
            {
                software.CreateSubKey("RXYFYECHAOCHENG");
            }
            subkeyName = admindir.GetValueNames();
            foreach (var KeyName in subkeyName)
            {
                if (KeyName==name)
                {
                    _exit = true;
                    hkml.Close();
                    software.Close();
                    admindir.Close();
                    return _exit;  
                }
            }
            hkml.Close();
            software.Close();
            admindir.Close();
            return _exit;
        }
        /// <summary>
        /// 写入注册表
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="value">值</param>
        static public void WriteRegdit(string name, string value)
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey software = hklm.OpenSubKey("SOFTWARE", true);
            RegistryKey admindir = software.OpenSubKey("RXYFYECHAOCHENG", true);
            admindir.SetValue(name,value);
            hklm.Close();
            software.Close();
            admindir.Close();
        }
        static public String GetRegValue(string str)
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey software = hklm.OpenSubKey("SOFTWARE", true);
            RegistryKey admindir = software.OpenSubKey("RXYFYECHAOCHENG", true);
            object str1=admindir.GetValue(str);
            hklm.Close();
            software.Close();
            admindir.Close();
            return  Convert.ToString(str1);
        }

    }
}