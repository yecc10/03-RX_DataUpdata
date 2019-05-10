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
