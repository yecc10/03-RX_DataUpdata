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
        DataTable BPL; //BoardPictureList
        DataTable PPL; //PointPictureLisT

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
                rxyF_YECCDataSet.Tables["BoardData"].DefaultView.Sort = "BID";
                this.boardDataTableAdapter.FillBy2CS_SerchBoardPictureList(this.rxyF_YECCDataSet.BoardData, Convert.ToDouble(Bat), Convert.ToDouble(Bbt));
                BPL =this.rxyF_YECCDataSet.Tables["BoardData"].DefaultView.ToTable();
            }
        }
        #region 读取试板图片，每次仅返回一个试板正反照
        /// <summary>
        /// 读取试板图片，每次仅返回一个试板正反照
        /// </summary>
        /// <param name="BID">需要读取试板的BID</param>
        /// <returns>NULL为读取失败</returns>
        public BoardPictureAndRemark ReadBoardPicture(string BID)
        {
            try
            {
                this.boardDataTableAdapter.FillBy(this.rxyF_YECCDataSet.BoardData, BID);
                DataRow DR;
                DR = rxyF_YECCDataSet.Tables["BoardData"].Rows[0];
                if (DR.Table.Rows.Count == 1)
                {
                    BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
                    BPAR.FwPictured = Convert.ToString(DR["FwPicture"]);
                    BPAR.BwPicture = Convert.ToString(DR["BwPicture"]);
                    BPAR.ReMark = Convert.ToString(DR["ReMark"]);
                    return BPAR;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion
        #region  读取焊点图片，每次仅返回一个焊点正反照
        /// <summary>
        /// 读取焊点图片，每次仅返回一个焊点正反照
        /// </summary>
        /// <param name="BID">需要读取试板的BID</param>
        /// <returns>NULL为读取失败</returns>
        public BoardPictureAndRemark ReadPointPicture(string PID)
        {
            try
            {
                this.sportDataTableAdapter.FillBy_SerchPidPicture(this.rxyF_YECCDataSet.SportData, PID);
                DataRow DR;
                DR = rxyF_YECCDataSet.Tables["SportData"].Rows[0];
                if (DR.Table.Rows.Count == 1)
                {
                    BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
                    BPAR.FwPictured = Convert.ToString(DR["FwPicture"]);
                    BPAR.BwPicture = Convert.ToString(DR["BwPicture"]);
                    BPAR.ReMark = Convert.ToString(DR["BZ备注"]);
                    return BPAR;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
        #endregion
    }
}
