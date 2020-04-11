using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SearchProLineBLL
    {
        #region 常量、变量的定义
        SearchProLineDAL suld = new SearchProLineDAL();  //实例化一个DAL层的对象用于访问方法
        #endregion

        #region 根据用户点击的省份名字显示该省分数线
        public DataTable ProLineGet(string proName)
        {
            return suld.GetProLine(proName);
        } 
        #endregion

        #region 根据用户点击的省份名字和年份显示该省分数线
        public DataTable ProLineGet(string proName, string year)
        {
            return suld.GetProLine(proName,year);
        }
        #endregion

        #region 根据用户点击的省份名字、年份和考生类别显示该省分数线
        public DataTable ProLineGet1(string proName, string year,string type)
        {
            return suld.GetProLine1(proName, year, type);
        }
        #endregion

        #region 根据用户点击的省份名字、年份和录取批次显示该省分数线
        public DataTable ProLineGet2(string proName, string year, string batch)
        {
            return suld.GetProLine2(proName, year, batch);
        }
        #endregion

        #region 根据用户点击的省份名字、年份、录取批次和考生类别显示该省分数线
        public DataTable ProLineGet(string proName, string year, string type,string batch)
        {
            return suld.GetProLine(proName, year, type, batch);
        }
        #endregion
    }
}
