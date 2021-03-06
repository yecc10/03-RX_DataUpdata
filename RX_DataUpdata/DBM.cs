﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RX_DataUpdata
{
    class DBM
    {
    }
    /// <summary>
    /// 实验数据数据库操作总集
    /// </summary>
    public class NewExp
    {
        #region 插入实验数据
        /// <summary>
        /// 插入实验数据
        /// </summary>
        /// <param name="pid">焊点ID</param>
        /// <param name="b1t">第一层板厚</param>
        /// <param name="b2t">第二层板厚</param>
        /// <param name="b3t">第三层板厚</param>
        /// <param name="b3m">第三层板材料</param>
        /// <param name="poleDim">端面直径</param>
        /// <param name="presstime">预压时间</param>
        /// <param name="weldele">焊接电流</param>
        /// <param name="weldtime">焊接时间</param>
        /// <param name="keeptime">维持时间</param>
        /// <param name="pressure">焊接压力</param>
        /// <param name="sportDim">焊点直径</param>
        /// <param name="rongheDim">熔核直径</param>
        /// <param name="remarks">备注</param>
        /// <param name="zhanjian">是否为凿检点</param>
        /// <param name="fistPoint">是否修磨后第一个焊点</param>
        /// <param name="endPoint">当前参数最终焊点</param>
        /// <param name="Ret">返回执行结果</param>
        static public int AddExp(string bid, string pid, double b1t, double b2t, double b3t, string b3m, double poleDim, double presstime, double weldele, double weldtime, double keeptime, double pressure, double sportDim,
            double rongheDim, string remarks, bool zhanjian, bool fistPoint, bool endPoint, bool Zhanfu, bool LieWen, bool FeiJian, bool YaHeng, bool WaiGuanNG, bool LianXuHanDian, bool HanJieJianXi, string FwPicture, string BwPicture, int? Ret)
        {
            MSEDataContext ND = new MSEDataContext();
            try
            {
                ND.NewExp(bid, pid, b1t, b2t, b3t, b3m, poleDim, presstime, weldele, weldtime, keeptime, pressure, sportDim, rongheDim, remarks, zhanjian, fistPoint, endPoint, Zhanfu, LieWen, FeiJian, YaHeng, WaiGuanNG, LianXuHanDian, HanJieJianXi, FwPicture, BwPicture, ref Ret);
                ND.SubmitChanges();
                return Convert.ToInt16(Ret);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
        #region 读取实验数据
        /// <summary>
        /// 读取实验数据
        /// </summary>
        /// <param name="pid">焊点ID</param>
        /// <param name="b1t">第一层板厚</param>
        /// <param name="b2t">第二层板厚</param>
        /// <param name="b3t">第三层板厚</param>
        /// <param name="b3m">第三层板材料</param>
        /// <param name="poleDim">端面直径</param>
        /// <param name="presstime">预压时间</param>
        /// <param name="weldele">焊接电流</param>
        /// <param name="weldtime">焊接时间</param>
        /// <param name="keeptime">维持时间</param>
        /// <param name="pressure">焊接压力</param>
        /// <param name="sportDim">焊点直径</param>
        /// <param name="rongheDim">熔核直径</param>
        /// <param name="remarks">备注</param>
        /// <param name="zhanjian">是否为凿检点</param>
        /// <param name="fistPoint">是否修磨后第一个焊点</param>
        /// <param name="endPoint">当前参数最终焊点</param>
        /// <param name="Ret">返回执行结果</param>
        /// <returns></returns>
        static public ReadPonit ReadExp(string pid)
        {
            double? b1t = 0, b2t = 0, b3t = 0, poleDim = 0, presstime = 0, weldele = 0, weldtime = 0, keeptime = 0, pressure = 0, sportDim = 0, rongheDim = 0;
            bool? zaojian = false, fistPoint = false, endPoint = false, Zhanfu = false, LieWen = false, FeiJian = false, YaHeng = false, WaiGuanNG = false, LianXuHanDian = false, HanJieJianXi = false;
            string b3m = string.Empty, remarks = string.Empty, FwPicture = String.Empty, BwPicture = string.Empty;
            MSEDataContext NE = new MSEDataContext();
            try
            {
                int? Ret = 0;
                NE.SerchExp(pid, ref b1t, ref b2t, ref b3t, ref b3m, ref poleDim, ref presstime, ref weldele, ref weldtime, ref keeptime, ref pressure, ref sportDim, ref rongheDim, ref remarks, ref zaojian, ref fistPoint, ref endPoint,
                    ref Zhanfu, ref LieWen, ref FeiJian, ref YaHeng, ref WaiGuanNG, ref LianXuHanDian, ref HanJieJianXi, ref FwPicture, ref BwPicture, ref Ret);
                NE.SubmitChanges();
                ReadPonit sp = new ReadPonit()
                {
                    pid = pid, b1t = Convert.ToDouble(b1t),
                    b2t = Convert.ToDouble(b2t),
                    b3t = Convert.ToDouble(b3t),
                    b3m = Convert.ToString(b3m),
                    poleDim = Convert.ToDouble(poleDim),
                    presstime = Convert.ToDouble(presstime),
                    weldele = Convert.ToDouble(weldele),
                    weldtime = Convert.ToDouble(weldtime),
                    keeptime = Convert.ToDouble(keeptime),
                    pressure = Convert.ToDouble(pressure),
                    sportDim = Convert.ToDouble(sportDim),
                    rongheDim = Convert.ToDouble(rongheDim),
                    remarks = Convert.ToString(remarks),
                    zaoJian = Convert.ToBoolean(zaojian),
                    fistPoint = Convert.ToBoolean(fistPoint),
                    endPoint = Convert.ToBoolean(endPoint),
                    Zhanfu = Convert.ToBoolean(Zhanfu),
                    lieWen = Convert.ToBoolean(LieWen),
                    FeiJian = Convert.ToBoolean(FeiJian),
                    Yaheng = Convert.ToBoolean(YaHeng),
                    Waiguan = Convert.ToBoolean(WaiGuanNG),
                    AlongPonit = Convert.ToBoolean(LianXuHanDian),
                    Jianxi = Convert.ToBoolean(HanJieJianXi),
                    FwPicture = Convert.ToString(FwPicture),
                    BwPicture = Convert.ToString(BwPicture),
                    Res = Convert.ToInt16(Ret)
                };
                return sp;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region BID&PID转换成数据库PID
        /// <summary>
        /// BID&PID转换成数据库PID
        /// </summary>
        /// <param name="text">BID.Text值</param>
        /// <param name="text2">PID.Text值</param>
        /// <returns></returns>
        static public SportName GetPid(string text, string text2)
        {
            if (text.Length < 6)
            {
                int len = 6 - text.Length;
                switch (len)
                {
                    case 2:
                        {
                            string p = text.Substring(0, 3);
                            string p1 = text.Substring(3, 1);
                            string p2 = p + "00" + p1;
                            text = p2;
                            break;
                        }
                    case 1:
                        {
                            string p = text.Substring(0, 3);
                            string p1 = text.Substring(3, 2);
                            string p2 = p + "0" + p1;
                            text = p2;
                            break;
                        }
                }
            }
            if (text2.Length < 2)
            {
                text2 = "0" + text2; //BID
                text2 = text + text2; //PID
            }
            else
            {
                text2 = text + text2;
            }
            SportName SN = new SportName() { Bid = text, Pid = text2 };
            return SN;
        }
        #endregion
        #region 更新实验数据
        /// <summary>
        /// 更新实验数据
        /// </summary>
        /// <param name="pid">焊点ID</param>
        /// <param name="b1t">第一层板厚</param>
        /// <param name="b2t">第二层板厚</param>
        /// <param name="b3t">第三层板厚</param>
        /// <param name="b3m">第三层板材料</param>
        /// <param name="poleDim">端面直径</param>
        /// <param name="presstime">预压时间</param>
        /// <param name="weldele">焊接电流</param>
        /// <param name="weldtime">焊接时间</param>
        /// <param name="keeptime">维持时间</param>
        /// <param name="pressure">焊接压力</param>
        /// <param name="sportDim">焊点直径</param>
        /// <param name="rongheDim">熔核直径</param>
        /// <param name="remarks">备注</param>
        /// <param name="zhanjian">是否为凿检点</param>
        /// <param name="fistPoint">是否修磨后第一个焊点</param>
        /// <param name="endPoint">当前参数最终焊点</param>
        /// <param name="Ret">返回执行结果</param>
        static public int UpdataExp(string bid, string pid, double b1t, double b2t, double b3t, string b3m, double poleDim, double presstime, double weldele, double weldtime, double keeptime,
            double pressure, double sportDim, double rongheDim, string remarks, bool zhanjian, bool fistPoint, bool endPoint, bool Zhanfu, bool LieWen, bool FeiJian, bool YaHeng, bool WaiGuanNG, bool LianXuHanDian, bool HanJieJianXi, string FwPicture, string BwPicture)
        {
            int? Ret = 0;
            MSEDataContext mSEData = new MSEDataContext();
            try
            {
                mSEData.UpdataExp(bid, pid, b1t, b2t, b3t, b3m, poleDim, presstime, weldele, weldtime, keeptime, pressure, sportDim, rongheDim, remarks, zhanjian, fistPoint, endPoint, Zhanfu, LieWen, FeiJian, YaHeng, WaiGuanNG, LianXuHanDian, HanJieJianXi, FwPicture, BwPicture, ref Ret);
                mSEData.SubmitChanges();
                return Convert.ToInt16(Ret);
            }
            catch (Exception)
            {
                throw;
            }
        }

    #endregion
        #region 上传并创建试板照片和备注
    /// <summary>
    /// 上传并创建试板照片和备注
    /// </summary>
    /// <param name="BID">焊点BID</param>
    /// <param name="FwPicture">试板正面照</param>
    /// <param name="BwPicture">试板反面照</param>
    /// <param name="ReMark">试板最终备注</param>
    /// <returns>11执行成功 -11文件已存在 0执行失败</returns>
    static public int CreatBoardPictureAndRemark(string BID, string FwPicture, string BwPicture, string ReMark)
    {
        MSEDataContext MSE = new MSEDataContext();
        int? Ret = 0;
        try
        {
            MSE.CreatBoardPictureAndRemark(BID, FwPicture, BwPicture, ReMark, ref Ret);
            if (Ret == 11)
            {
                return 11;
            }
            else if (Ret == -11)
            {
                return -11;
            }
            else
            {
                return 0;
            }
        }
        catch (Exception)
        {
            return 0;
        }

    }
        #endregion
        #region 更新已有试板照片和备注
        /// <summary>
        /// 更新已有试板照片和备注
        /// </summary>
        /// <param name="BID">焊点BID</param>
        /// <param name="FwPicture">试板正面照</param>
        /// <param name="BwPicture">试板反面照</param>
        /// <param name="ReMark">试板最终备注</param>
        /// <returns>11执行成功 -11文件已存在 0执行失败</returns>
        static public int UpdataBoardPictureAndRemark(string BID, string FwPicture, string BwPicture, string ReMark)
        {
            MSEDataContext MSE = new MSEDataContext();
            int? Ret = 0;
            try
            {
                MSE.UpdateBoardPictureAndRemark(BID, FwPicture, BwPicture, ReMark, ref Ret);
                if (Ret == 11)
                {
                    return 11;
                }
                else if (Ret == -11)
                {
                    return -11;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        #endregion
    }
}
