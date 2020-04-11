using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchUniversityLineDAL
    {
        #region 不包含大学名字的查询
        #region 通过用户输入的大学名称模糊查询该大学对于各个省份的录取线信息
        public DataTable GetByUniversityName(string universityName)
        {
            string sql = "SELECT * FROM universityline WHERE u_name LIKE '%" + universityName + "%'";

            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 查询某一年的所有大学录取线
        public DataTable GetByYear(string year)
        {
            string sql = "SELECT * FROM universityline WHERE year = '" + year + "'";

            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 按照录取批次和年份查询大学录取线
        public DataTable GetByBatchAndYear(string batch, string year)
        {
            string sql = "SELECT * FROM universityline WHERE batch = '" + batch + "'AND year = '" + year + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 查询某一省份的大学在某一年的录取线
        public DataTable GetByProAndYear(string proName, string year)
        {
            string sql = "SELECT u_name,local_province_name,type,year,batch,average_score,min_score,pro_score FROM " +
                "view_universityline WHERE belong_pro = '" + proName + "'AND year = '" + year + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 按省份、录取批次查询某一年的分数信息
        public DataTable GetByProAndBatchAndYear(string proName, string batch, string year)
        {
            string sql = "SELECT u_name,local_province_name,type,year,batch,average_score,min_score,pro_score FROM " +
                "view_universityline WHERE belong_pro = '" + proName + "' AND year = '" + year + "' AND batch = '" + batch + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 查询不同类别在某一年的分数信息
        public DataTable GetByTypeAndYear(string type, string year)
        {
            string sql = "SELECT * FROM universityline WHERE type = '" + type + "'AND year = '" + year + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 按类别、批次查询某一年的分数信息
        public DataTable GetByTypeAndBatchAndYear(string type, string batch, string year)
        {
            string sql = "SELECT * FROM universitylne WHERE type = '" + type + "'AND batch = '" + batch + "'AND " +
                "year = '" + year + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 查询某一省份某一类别某一年的分数信息
        public DataTable GetByProAndTypeAndYear(string proName, string type, string year)
        {
            string sql = "SELECT u_name,local_province_name,type,year,batch,average_score,min_score,pro_score FROM " +
                "view_universityline WHERE belong_pro = '" + proName + "'AND type = '" + type + "' AND year = '" + year + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 按类别、省份、录取批次查询某一年的分数信息
        public DataTable GetByTypeAndProAndBatchAndYear(string type, string proName, string batch, string year)
        {
            string sql = "SELECT u_name,local_province_name,type,year,batch,average_score,min_score,pro_score FROM " +
                "view_universityline WHERE belong_pro = '" + proName + "'AND type = '" + type + "' AND year = '" + year + "'" +
                "AND batch = '" + batch + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion
        #endregion

        #region 包含大学名字的查询
        #region 查询某一年的所有大学录取线（包含名字）
        public DataTable GetByYearAndName(string year, string uName)
        {
            string sql = "SELECT * FROM universityline WHERE year = '" + year + "'AND u_Name LIKE '%" + uName + "%'";

            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 按照录取批次和年份查询大学录取线（包含名字）
        public DataTable GetByBatchAndYearAndName(string batch, string year, string uName)
        {
            string sql = "SELECT * FROM universityline WHERE batch = '" + batch + "'AND year = '" + year +
                "'AND u_Name LIKE '%" + uName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 查询某一省份的大学在某一年的录取线（包含名字）
        public DataTable GetByProAndYearAndName(string proName, string year, string uName)
        {
            string sql = "SELECT u_name,local_province_name,type,year,batch,average_score,min_score,pro_score FROM " +
                "view_universityline WHERE belong_pro = '" + proName + "'AND year = '" + year + "'AND u_Name LIKE '%" +
                uName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 按省份、录取批次查询某一年的分数信息（包含名字）
        public DataTable GetByProAndBatchAndYearAndName(string proName, string batch, string year, string uName)
        {
            string sql = "SELECT u_name,local_province_name,type,year,batch,average_score,min_score,pro_score FROM " +
                "view_universityline WHERE belong_pro = '" + proName + "' AND year = '" + year + "' AND batch = '" +
                batch + "'AND u_Name LIKE '%" + uName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 查询不同类别在某一年的分数信息（包含名字）
        public DataTable GetByTypeAndYearAndName(string type, string year, string uName)
        {
            string sql = "SELECT * FROM universityline WHERE type = '" + type + "'AND year = '" + year + "'AND" +
                " u_Name LIKE '%" + uName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 按类别、批次查询某一年的分数信息（包含名字）
        public DataTable GetByTypeAndBatchAndYearAndName(string type, string batch, string year, string uName)
        {
            string sql = "SELECT * FROM universitylne WHERE type = '" + type + "'AND batch = '" + batch + "'AND " +
                "year = '" + year + "'AND u_Name LIKE '%" + uName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 查询某一省份某一类别某一年的分数信息（包含名字）
        public DataTable GetByProAndTypeAndYearAndName(string proName, string type, string year, string uName)
        {
            string sql = "SELECT u_name,local_province_name,type,year,batch,average_score,min_score,pro_score FROM " +
                "view_universityline WHERE belong_pro = '" + proName + "'AND type = '" + type + "' AND year = '" +
                year + "'AND u_Name LIKE '%" + uName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 按类别、省份、录取批次查询某一年的分数信息（包含名字）
        public DataTable GetByTypeAndProAndBatchAndYearAndName(string type, string proName, string batch, string year, string uName)
        {
            string sql = "SELECT u_name,local_province_name,type,year,batch,average_score,min_score,pro_score FROM " +
                "view_universityline WHERE belong_pro = '" + proName + "'AND type = '" + type + "' AND year = '" + year + "'" +
                "AND batch = '" + batch + "'AND u_Name LIKE '%" + uName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion
        #endregion
    }
}
