using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RX_DataUpdata
{
    class DBM
    {
    }
    public class NewExp
    {
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
        /// <param name="zhanjian">是否粘件</param>
        /// <param name="fistPoint">是否修磨后第一个焊点</param>
        /// <param name="endPoint">当前参数最终焊点</param>
        /// <param name="Ret">返回执行结果</param>
       static public int AddExp(string bid,string pid,double b1t, double b2t, double b3t,string b3m, double poleDim, double presstime, double weldele, double weldtime, double keeptime, double pressure, double sportDim, double rongheDim,string remarks,bool zhanjian, bool fistPoint, bool endPoint,int? Ret)
        {
            MSEDataContext ND = new MSEDataContext();
            try
            {
                ND.NewExp(bid,pid,b1t, b2t, b3t, b3m, poleDim, presstime, weldele, weldtime, keeptime, pressure, sportDim, rongheDim, remarks,zhanjian,fistPoint,endPoint, ref Ret);
                ND.SubmitChanges();
                return Convert.ToInt16(Ret);

            }
            catch(Exception e)
            {
                throw e;
            }
        }
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
        /// <returns></returns>
        static public Spoint ReadExp(string pid)
        {
            double? b1t=0, b2t = 0, b3t = 0, poleDim = 0, presstime = 0, weldele = 0, weldtime = 0, keeptime = 0, pressure = 0, sportDim = 0, rongheDim = 0;
            bool? zhanjian=false, fistPoint = false, endPoint = false;
            string b3m=string.Empty, remarks = string.Empty;
            MSEDataContext NE = new MSEDataContext();
            try
            {
                NE.SerchExp(pid, ref b1t, ref b2t, ref b3t, ref b3m, ref poleDim, ref presstime, ref weldele, ref weldtime, ref keeptime, ref pressure, ref sportDim, ref rongheDim, ref remarks, ref zhanjian, ref fistPoint, ref endPoint);
                NE.SubmitChanges();
                Spoint sp = new Spoint()
                {
                    pid = pid, b1t = Convert.ToDouble(b1t),
                    b2t = Convert.ToDouble(b2t),
                    b3t = Convert.ToDouble(b3t) ,
                    b3m = Convert.ToString(b3m) ,
                    poleDim = Convert.ToDouble(poleDim),
                    presstime = Convert.ToDouble(presstime),
                    weldele = Convert.ToDouble(weldele),
                    weldtime = Convert.ToDouble(weldtime),
                    keeptime = Convert.ToDouble(keeptime),
                    pressure = Convert.ToDouble(pressure),
                    sportDim = Convert.ToDouble(sportDim),
                    rongheDim = Convert.ToDouble(rongheDim),
                    remarks = Convert.ToString(remarks),
                    zaoJian = Convert.ToBoolean(zhanjian),
                    fistPoint = Convert.ToBoolean(fistPoint),
                    endPoint = Convert.ToBoolean(endPoint)
                };
                return sp; 
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// BID&PID转换成数据库PID
        /// </summary>
        /// <param name="text">BID.Text值</param>
        /// <param name="text2">PID.Text值</param>
        /// <returns></returns>
        static public string GetPid(string text, string text2)
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
            return text2;
        }

    }
    public class UpdataExp
    {
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
        public UpdataExp(string pid, double b1t, double b2t, double b3t, string b3m, double poleDim, double presstime, double weldele, double weldtime, double keeptime, double pressure, double sportDim, double rongheDim, string remarks)
        {
            MSEDataContext mSEData = new MSEDataContext();
            try
            {
                mSEData.UpdataExp(pid, b1t, b2t, b3t, b3m, poleDim, presstime, weldele, weldtime, keeptime, pressure, sportDim, rongheDim, remarks);
                mSEData.SubmitChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
