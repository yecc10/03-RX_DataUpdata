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
        DataTable BPL = null; //BoardPictureList
        DataTable PPLA = null; //PointPictureLisTA
        DataTable PPLB = null; //PointPictureLisTB
        BoardPictureAndRemark BARA = new BoardPictureAndRemark();
        BoardPictureAndRemark BARB = new BoardPictureAndRemark();
        BoardPictureAndRemark SARA = new BoardPictureAndRemark();
        BoardPictureAndRemark SARB = new BoardPictureAndRemark();
        string SModelA = "Board";
        string SModelB = "Board";
        int BoardLocationA = 1, BoardLocationB = 1, TotalBoardNum = 0;

        int SpointLocationA = 0, SpointLocationB = 0, TotalSpointNumA = 0, TotalSpointNumB = 0;

        private void NextBoard_Click(object sender, EventArgs e)
        {
            SModelA = "Board";
            LastBoard.Enabled = true;
            BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
            BoardLocationA += 1;
            if (BoardLocationA == TotalBoardNum)
            {
                NextBoard.Enabled = false;
            }
            string Tbid = BPL.Rows[BoardLocationA - 1][1].ToString();
            BPAR = ReadBoardPicture(Tbid);
            if (BPAR != null)
            {
                BARA = BPAR;
                PictureBoxA.ImageLocation = BPAR.FwPictured;
                PictureBoxA.Update();
                BoardNameA.Text = Tbid;
                ReadPointList(Tbid, "A");
                StatusA.Text = BoardLocationA + "/" + TotalBoardNum;
            }
            else
            {
                StatusA.Text = "NoBoardPicture";
            }
        }

        private void LastSpointB_Click(object sender, EventArgs e)
        {
            if (SpointLocationB == 1)
            {
                LastSpointB.Enabled = false;
                return;
            }
            SModelB = "Sport";
            NextSpointPictureB.Enabled = true;
            SpointLocationB -= 1;
            SportStatusB.Text = SpointLocationB + "/" + TotalSpointNumB;
            if (ReadPointPicture(BoardNameB.Text, "B"))
            {
                if (SpointLocationB <= 1)
                {
                    LastSpointB.Enabled = false;
                }
                PictureBoxB.ImageLocation = SARB.FwPictured;
                PictureBoxB.Update();
 
            }
        }

        private void NextSpointPictureB_Click(object sender, EventArgs e)
        {
            SModelB = "Sport";
            LastSpointB.Enabled = true;
            SpointLocationB += 1;
            SportStatusB.Text = SpointLocationB + "/" + TotalSpointNumB;
            if (ReadPointPicture(BoardNameB.Text, "B"))
            {
                if (SpointLocationB == TotalSpointNumB)
                {
                    NextSpointPictureB.Enabled = false;
                }
                PictureBoxB.ImageLocation = SARB.FwPictured;
                PictureBoxB.Update();
            }
        }

        private void LastBoardB_Click(object sender, EventArgs e)
        {
            SModelB = "Board";
            NextBoardB.Enabled = true;
            BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
            BoardLocationB -= 1;
            if (BoardLocationB <= 1)
            {
                LastBoardB.Enabled = false;
            }
            string Tbid = BPL.Rows[BoardLocationB - 1][1].ToString();
            BPAR = ReadBoardPicture(Tbid);
            if (BPAR != null)
            {
                BARB = BPAR;
                PictureBoxB.ImageLocation = BPAR.FwPictured;
                PictureBoxB.Update();
                BoardNameB.Text = Tbid;
                ReadPointList(Tbid, "B");
                StatusB.Text = BoardLocationB + "/" + TotalBoardNum;
            }
            else
            {
                StatusB.Text = "NoBoardPicture";
            }
        }

        private void NextBoardB_Click(object sender, EventArgs e)
        {
            SModelB = "Board";
            LastBoardB.Enabled = true;
            BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
            BoardLocationB += 1;
            if (BoardLocationB == TotalBoardNum)
            {
                NextBoardB.Enabled = false;
            }
            string Tbid = BPL.Rows[BoardLocationB - 1][1].ToString();
            BPAR = ReadBoardPicture(Tbid);
            if (BPAR != null)
            {
                BARB = BPAR;
                PictureBoxB.ImageLocation = BPAR.FwPictured;
                PictureBoxB.Update();
                BoardNameB.Text = Tbid;
                ReadPointList(Tbid, "B");
                StatusB.Text = BoardLocationB + "/" + TotalBoardNum;
            }
            else
            {
                StatusB.Text = "NoBoardPicture";
            }
        }

        private void FWPictureA_Click(object sender, EventArgs e)
        {
            switch (SModelA)
            {
                case "Board":
                    {
                        PictureBoxA.ImageLocation = BARA.FwPictured;
                        PictureBoxA.Update();
                        break;
                    }
                case "Sport":
                    {
                        PictureBoxA.ImageLocation = SARA.FwPictured;
                        PictureBoxA.Update();
                        break;
                    }     
            }
        }

        private void BWPictureA_Click(object sender, EventArgs e)
        {
            switch (SModelA)
            {
                case "Board":
                    {
                        PictureBoxA.ImageLocation = BARA.BwPicture;
                        PictureBoxA.Update();
                        break;
                    }
                case "Sport":
                    {
                        PictureBoxA.ImageLocation = SARA.BwPicture;
                        PictureBoxA.Update();
                        break;
                    }
            }

        }

        private void FWPictureB_Click(object sender, EventArgs e)
        {
            switch (SModelB)
            {
                case "Board":
                    {
                        PictureBoxB.ImageLocation = BARB.FwPictured;
                        PictureBoxB.Update();
                        break;
                    }
                case "Sport":
                    {
                        PictureBoxB.ImageLocation = SARB.FwPictured;
                        PictureBoxB.Update();
                        break;
                    }
            }
        }

        private void BWPictureB_Click(object sender, EventArgs e)
        {
            switch (SModelB)
            {
                case "Board":
                    {
                        PictureBoxB.ImageLocation = BARB.BwPicture;
                        PictureBoxB.Update();
                        break;
                    }
                case "Sport":
                    {
                        PictureBoxB.ImageLocation = SARB.BwPicture;
                        PictureBoxB.Update();
                        break;
                    }
            }
        }

        private void NextSpointPictureA_Click(object sender, EventArgs e)
        {
            SModelA = "Sport";
            LastSpointA.Enabled = true;
            SpointLocationA += 1;
            SportStatusA.Text = SpointLocationA + "/" + TotalSpointNumA;
            if (ReadPointPicture(BoardNameA.Text, "A"))
            {
                if (SpointLocationA == TotalSpointNumA)
                {
                    NextSpointPictureA.Enabled = false;
                }
                PictureBoxA.ImageLocation = SARA.FwPictured;
                PictureBoxA.Update();
            }
        }

        private void LastSpointA_Click(object sender, EventArgs e)
        {
            if (SpointLocationA==1)
            {
                LastSpointA.Enabled = false;
                return;
            }
            SModelA = "Sport";
            NextSpointPictureA.Enabled = true;
            SpointLocationA -= 1;
            SportStatusA.Text = SpointLocationA + "/" + TotalSpointNumA;
            if (ReadPointPicture(BoardNameA.Text, "A"))
            {
                if (SpointLocationA <=1)
                {
                    LastSpointA.Enabled = false;
                }
                PictureBoxA.ImageLocation = SARA.FwPictured;
                PictureBoxA.Update();
            }
        }

        private void LastBoard_Click(object sender, EventArgs e)
        {
            SModelA = "Board";
            LastBoard.Enabled = true;
            BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
            BoardLocationA -= 1;
            if (BoardLocationA <= 1)
            {
                LastBoard.Enabled = false;
            }
            string Tbid = BPL.Rows[BoardLocationA - 1][1].ToString();
            BPAR = ReadBoardPicture(Tbid);
            if (BPAR != null)
            {
                BARA = BPAR;
                PictureBoxA.ImageLocation = BPAR.FwPictured;
                PictureBoxA.Update();
                BoardNameA.Text = Tbid;
                ReadPointList(Tbid, "A");
                StatusA.Text = BoardLocationA + "/" + TotalBoardNum;
            }
            else
            {
                StatusA.Text = "NoBoardPicture";
            }
        }

        /// <summary>
        /// 调用焊点图片显示窗口
        /// </summary>
        /// <param name="Bat">第一层板厚</param>
        /// <param name="Bbt">第二层板厚</param>
        /// <param name="Bct">第三层板厚</param>
        /// <param name="Bcm">第三层材料</param>
        /// /// <param name="SerchModel">查询模式-默认料厚查询-此次暂不写入程序</param>
        public DChartShowPointImage(string Bat, string Bbt, string Bct, string Bcm, string SerchModel)
        {
            InitializeComponent();
            if (Bcm != string.Empty && Bct != string.Empty)
            {
                //var RE = RxDataOprator.ExcelOprator.SaveExcelForLvSport(dataGridView1, "板件6061厚_" + Bat.Text + "_板件5052厚_" + Bbt.Text + "_板件_" + Bcm.Text + "_厚_" + Bct.Text + "_组合参数");
            }
            else
            {
                rxyF_YECCDataSet.Tables["BoardData"].DefaultView.Sort = "BID";
                this.boardDataTableAdapter.FillBy2CS_SerchBoardPictureList(this.rxyF_YECCDataSet.BoardData, Convert.ToDouble(Bat), Convert.ToDouble(Bbt));
                BPL = this.rxyF_YECCDataSet.Tables["BoardData"].DefaultView.ToTable();
                TotalBoardNum = BPL.Rows.Count;
                if (TotalBoardNum > 0)
                {
                    LastBoard.Enabled = false;
                    LastBoardB.Enabled = false;
                    LastSpointA.Enabled = false;
                    LastSpointB.Enabled = false;
                    this.Text = "焊点图片对比显示_本组实验共涉及_" + TotalBoardNum + "_个试板！";
                    BoardPictureAndRemark BPAR = new BoardPictureAndRemark();
                    string Tbid = BPL.Rows[0][1].ToString();
                    BPAR = ReadBoardPicture(Tbid);
                    BARA = BPAR;
                    BARB = BPAR;
                    PictureBoxA.ImageLocation = BPAR.FwPictured;
                    PictureBoxA.Update();
                    PictureBoxB.ImageLocation = BPAR.BwPicture;
                    PictureBoxB.Update();
                    BoardNameA.Text = Tbid;
                    BoardNameB.Text = Tbid;
                    ReadPointList(Tbid, "A");
                    ReadPointList(Tbid, "B");
                    StatusA.Text = "1/" + TotalBoardNum;
                    StatusB.Text = "1/" + TotalBoardNum;
                }
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
        #region 读取指定试板焊点总数以及焊点名数组
        /// <summary>
        ///读取指定试板焊点总数以及焊点名数组,赋值到全局变量无返回值
        /// </summary>
        /// <param name="BID">指定需要读取的试板BID</param>
        /// <param name="Type">输出到A图表位置/B位置</param>
        /// <returns></returns>
        public void ReadPointList(string BID, string Type)
        {
            try
            {
                rxyF_YECCDataSet.Tables["ExperienceView"].DefaultView.Sort = "PID";
                this.experienceViewTableAdapter.FillByPID(this.rxyF_YECCDataSet.ExperienceView, BID);
                switch (Type)
                {
                    case "A":
                        {
                            PPLA = this.rxyF_YECCDataSet.Tables["ExperienceView"].DefaultView.ToTable();
                            TotalSpointNumA = PPLA.Rows.Count;
                            SportStatusA.Text = SpointLocationA + "/" + TotalSpointNumA;
                            break;
                        }
                    case "B":
                        {
                            PPLB = this.rxyF_YECCDataSet.Tables["ExperienceView"].DefaultView.ToTable();
                            TotalSpointNumB = PPLB.Rows.Count;
                            SportStatusB.Text = SpointLocationA + "/" + TotalSpointNumB;
                            break;
                        }
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion
        #region  读取焊点图片，每次仅返回一个焊点正反照
        /// <summary>
        /// 读取焊点图片，每次仅返回一个焊点正反照
        /// </summary>
        /// <param name="BID">需要读取试板的BID</param>
        /// <returns>NULL为读取失败</returns>
        public bool ReadPointPicture(string PID, string Type)
        {
            switch (Type)
            {
                case "A":
                    {
                        PID = PPLA.Rows[SpointLocationA-1][2].ToString();
                        SpointNameA.Text = PID;
                        break;
                    }
                case "B":
                    {
                        PID = PPLA.Rows[SpointLocationB-1][2].ToString();
                        SpointNameB.Text = PID;
                        break;
                    }
            }
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
                    switch (Type)
                    {
                        case "A":
                            {
                                SARA = BPAR;
                                SportStatusA.Text = SpointLocationA+ "/" + TotalSpointNumA;
                                return true;
                            }
                        case "B":
                            {
                                SARB = BPAR;
                                SportStatusB.Text = SpointLocationB+ "/" + TotalSpointNumB;
                                return true;
                            }
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
