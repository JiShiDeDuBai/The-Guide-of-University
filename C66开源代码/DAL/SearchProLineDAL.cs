using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchProLineDAL
    {
        #region 根据用户点击的省份名字显示该省分数线
        public DataTable GetProLine(string proName)
        {
            string sql = "SELECT * FROM provinceline WHERE proname = '" + proName + "'";

            return PgHelper.ExcuteDataTable(sql);
        } 
        #endregion

        #region 根据用户点击的省份名字和年份显示该省分数线
        public DataTable GetProLine(string proName,string year)
        {
            string sql = "SELECT * FROM provinceline WHERE proname = '" + proName + "'AND year = '" + year + "'";

            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据用户点击的省份名字、年份和考生类别显示该省分数线
        public DataTable GetProLine1(string proName, string year, string type)
        {
            string sql = "SELECT * FROM provinceline WHERE proname = '" + proName + "'AND year = '" + year + "'AND type = '" + type + "'";

            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据用户点击的省份名字、年份和录取批次显示该省分数线
        public DataTable GetProLine2(string proName, string year, string batch)
        {
            string sql = "SELECT * FROM provinceline WHERE proname = '" + proName + "'AND year = '" + year + "'AND batch = '" + batch + "'";

            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据用户点击的省份名字、年份、考生类别和录取批次显示该省分数线
        public DataTable GetProLine(string proName, string year, string type, string batch)
        {
            string sql = "SELECT * FROM provinceline WHERE proname = '" + proName + "'AND year = '" + year + "'AND type = '" + type + "' AND batch = '" + batch + "'";

            return PgHelper.ExcuteDataTable(sql);
        } 
        #endregion
    }
}
