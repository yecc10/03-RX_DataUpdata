using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RX_DataUpdata
{
    public partial class DChartShowPointImage : Form
    {
        DataRow BoardPictureList;
        DataRow PointPictureList;
        /// <summary>
        /// 调用焊点图片显示窗口
        /// </summary>
        /// <param name="Bat">第一层板厚</param>
        /// <param name="Bbt">第二层板厚</param>
        /// <param name="Bct">第三层板厚</param>
        /// <param name="Bcm">第三层材料</param>
        /// /// <param name="SerchModel">查询模式-默认料厚查询-此次暂不写入程序</param>
        public DChartShowPointImage(string Bat,string Bbt,string Bct,string Bcm,string SerchModel)
        {
            InitializeComponent();
            if (Bcm!= string.Empty && Bct!= string.Empty)
            {
                //var RE = RxDataOprator.ExcelOprator.SaveExcelForLvSport(dataGridView1, "板件6061厚_" + Bat.Text + "_板件5052厚_" + Bbt.Text + "_板件_" + Bcm.Text + "_厚_" + Bct.Text + "_组合参数");
            }
            else
            {
                //var RE = RxDataOprator.ExcelOprator.SaveExcelForLvSport(dataGridView1, "板件6061厚_" + Bat.Text + "_板件5052厚_" + Bbt.Text + "_组合参数");
            }
        }
    }
}
