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
  public  class Spoint
    {
        /// <summary>
        /// 实验版ID
        /// </summary>
        public virtual  string bid { get; set; }
        /// <summary>
        /// 实验焊点ID
        /// </summary>
        public virtual  string pid { get; set; }
        /// <summary>
        /// 上层板厚度，默认材料6061
        /// </summary>
        public virtual  double b1t { get; set; }
        /// <summary>
        /// 下层板厚度，默认材料5052
        /// </summary>
        public virtual double b2t { get; set; }
        /// <summary>
        /// 第三层板材料厚度
        /// </summary>
        public virtual double b3t { get; set; }
        /// <summary>
        ///第三层板材料
        /// </summary>
        public virtual string b3m { get; set; }
        /// <summary>
        /// 焊点直径
        /// </summary>
        public virtual double poleDim { get; set; }
        /// <summary>
        /// 加压时间
        /// </summary>
        public virtual double presstime { get; set; }
        /// <summary>
        /// 焊接电流
        /// </summary>
        public virtual double weldele { get; set; }
        /// <summary>
        /// 焊接时间
        /// </summary>
        public virtual double weldtime { get; set; }
        /// <summary>
        /// 保持时间
        /// </summary>
        public virtual double keeptime { get; set; }
        /// <summary>
        /// 焊接压力
        /// </summary>
        public virtual double pressure { get; set; }
        /// <summary>
        /// 焊点直径
        /// </summary>
        public virtual double sportDim { get; set; }
        /// <summary>
        /// 熔合直径
        /// </summary>
        public virtual double rongheDim { get; set; }
        /// 是否凿检
        /// </summary>
        public virtual bool zaoJian { get; set; }
        /// <summary>
        /// 修磨后首个焊点
        /// </summary>
        public virtual bool fistPoint { get; set; }
        /// <summary>
        /// 该搭接最终焊点
        /// </summary>
        public virtual bool endPoint { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public virtual string remarks { get; set; }
        /// <summary>
        /// 粘附
        /// </summary>
        public virtual bool Zhanfu { get; set; }
        /// <summary>
        /// 裂纹
        /// </summary>
        public virtual bool lieWen { get; set; }
        /// <summary>
        /// 飞溅
        /// </summary>
        public virtual bool FeiJian { get; set; }
        /// <summary>
        /// 压痕
        /// </summary>
        public virtual bool Yaheng { get; set; }
        /// <summary>
        /// 外观质量NG
        /// </summary>
        public virtual bool Waiguan { get; set; }
        /// <summary>
        /// 连续焊点
        /// </summary>
        public virtual bool AlongPonit { get; set; }
        /// <summary>
        /// 存在焊接间隙
        /// </summary>
        public virtual bool Jianxi { get; set; }
    }

    public class ReadPonit:Spoint
    {
        public virtual int Res { get; set; }
        public virtual string FwPicture { get; set; }
        public virtual string BwPicture { get; set; }
    }

    /// <summary>
    /// 焊点编号集BID/PID
    /// </summary>
    public class SportName
    {
        public virtual string Bid { get; set; }
        public virtual string Pid { get; set; }
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