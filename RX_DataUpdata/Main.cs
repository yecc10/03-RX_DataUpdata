﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RX_DataUpdata
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            int Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            int heigh= System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            this.MinimumSize = new System.Drawing.Size(Width, heigh);
            this.MaximumSize=new System.Drawing.Size(Width, heigh);
            this.WBEXP.Size = new System.Drawing.Size(Width - 54, heigh - 100);
            this.WBEXP.IsWebBrowserContextMenuEnabled= false;
            this.WBEXP.WebBrowserShortcutsEnabled = false;
            this.MainTabContent.Size = new System.Drawing.Size(Width - 54, heigh - 100);
            this.工具集.Size = new System.Drawing.Size(Width - 54, heigh - 100);
            this.CenterToScreen();
            this.CIP.Text = SysVar.ClientIP;
            this.SIP.Text = SysVar.SIP;
            Utime.Enabled = true;
            try
            {
                string str = "http://" + SysVar.SIP + ":8090/";
                this.WBEXP.Navigate(new Uri(str));
                this.WBEXP.Update();
            }
            catch (Exception)
            {

                throw;
            }
            UserName.Text = SysVar.UserName;
            LoginTime.Text = DateTime.Now.ToLongDateString().ToString();
        }

        private void DataUpdata_Click(object sender, EventArgs e)
        {
            this.Hide();
            ME mme = new ME();
            mme.ShowDialog();
        }

        private void DataControl_Click(object sender, EventArgs e)
        {
            DChart dc = new DChart();
            dc.ShowDialog();
        }

        private void MOK_Click(object sender, EventArgs e)
        {
            DChart dChart = new DChart();
            dChart.Show();
        }

        private void NewLvSport_Click(object sender, EventArgs e)
        {
                ME mE = new ME();
                mE.Show();
        }

        private void DataSerch_Click(object sender, EventArgs e)
        {
            DChart dChart = new DChart();
            dChart.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“aLTDataBaseDataSet.SportData”中。您可以根据需要移动或删除它。
            this.sportDataTableAdapter1.Fill(this.aLTDataBaseDataSet.SportData);
            // TODO: 这行代码将数据加载到表“rXYF_YECCDataSet.SportData”中。您可以根据需要移动或删除它。
            this.sportDataTableAdapter.Fill(this.rXYF_YECCDataSet.SportData);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoginTime.Text = DateTime.Now.ToString();
        }

        private void Oprate_Click(object sender, EventArgs e)
        {
            this.PlantValue.Text =Convert.ToString( Convert.ToDouble(CadValue.Text)/1000*20);
        }

        private void UpdataALdata_Click(object sender, EventArgs e)
        {
            ME_Updata MEU = new ME_Updata();
            MEU.ShowDialog();
        }
        private void MainTabContent_Click(object sender, EventArgs e)
        {
            switch (MainTabContent.SelectedTab.Name)
            {
                case "CatiaHelp":
                    webBrowser1.Navigate(new Uri("http://rx_yfb_yf079:7080/"));
                    break;
                case "DelmiaHelp":
                    webBrowser1.Navigate(new Uri("http://rx_yfb_yf079:7090/"));
                    break;
            }
            
        }
    }
}
