using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchSpecialLineDAL
    {
        #region 根据专业名字查询专业录取线
        public DataTable GetSpecialLineBySpecialName(string specialName)
        {
            string sql = "SELECT * FROM specialline WHERE special_name like  '%" + specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份选择展示所有专业信息
        public DataTable GetSpecialLineByYear(string year)
        {
            string sql = "SELECT * FROM specialline WHERE year = '" + year + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份和批次展示所有专业信息
        public DataTable GetSpecialLineByYearAndBatch(string year, string batch)
        {
            string sql = "SELECT * FROM specialline WHERE year = '" + year + "' AND batch = '" + batch + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、所属地区展示所有专业信息
        public DataTable GetSpecialLineByYearAndPro(string year, string proName)
        {
            string sql = "SELECT u_name,special_name,local_province_name,type,year,batch,average_score,min_score FROM " +
                "view_specialline WHERE year = '" + year + "' AND belong_pro = '" + proName + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、所属地区和批次展示所有专业信息
        public DataTable GetSpecialLineByYearAndProAndBatch(string year, string proName, string batch)
        {
            string sql = "SELECT u_name,special_name,local_province_name,type,year,batch,average_score,min_score FROM " +
                "view_specialline WHERE year = '" + year + "' AND belong_pro = '" + proName + "' AND batch = '" + batch + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、考生类型展示所有专业信息
        public DataTable GetSpecialLineByYearAndType(string year, string type)
        {
            string sql = "SELECT * FROM specialline WHERE year = '" + year + "' AND type = '" + type + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、考生类型和录取批次展示所有专业信息
        public DataTable GetSpecialLineByYearAndTypeAndBatch(string year, string type, string batch)
        {
            string sql = "SELECT * FROM specialline WHERE year = '" + year + "' AND type = '" + type + "'AND batch = " +
                "'" + batch + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、考生类型和所属地区展示所有专业信息
        public DataTable GetSpecialLineByYearAndTypeAndPro(string year, string type, string proName)
        {
            string sql = "SELECT u_name,special_name,local_province_name,type,year,batch,average_score,min_score FROM " +
                "view_specialline WHERE year = '" + year + "' AND type = '" + type + "' AND belong_pro = '" + proName + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、考生类型、所属地区和录取批次展示所有专业信息
        public DataTable GetSpecialLineByYearAndTypeAndProAndBatch(string year, string type, string proName, string batch)
        {
            string sql = "SELECT u_name,special_name,local_province_name,type,year,batch,average_score,min_score FROM " +
                "view_specialline WHERE year = '" + year + "' AND type = '" + type + "' AND belong_pro = '" + proName + "'" +
                "AND batch = '" + batch + "'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion


        #region 根据年份选择展示所有专业信息(包括专业名称)
        public DataTable GetSpecialLineByYear(string year, string specialName)
        {
            string sql = "SELECT * FROM specialline WHERE year = '" + year + "'AND special_name like '%" + specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份和批次展示所有专业信息(包括专业名称)
        public DataTable GetSpecialLineByYearAndBatch(string year, string batch, string specialName)
        {
            string sql = "SELECT * FROM specialline WHERE year = '" + year + "' AND batch = '" + batch + "'AND " +
                "special_name like '%" + specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、所属地区展示所有专业信息(包括专业名称)
        public DataTable GetSpecialLineByYearAndPro(string year, string proName, string specialName)
        {
            string sql = "SELECT u_name,special_name,local_province_name,type,year,batch,average_score,min_score FROM " +
                "view_specialline WHERE year = '" + year + "' AND belong_pro = '" + proName + "'AND special_name like '%" +
                specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、所属地区和批次展示所有专业信息(包括专业名称)
        public DataTable GetSpecialLineByYearAndProAndBatch(string year, string proName, string batch, string specialName)
        {
            string sql = "SELECT u_name,special_name,local_province_name,type,year,batch,average_score,min_score FROM " +
                "view_specialline WHERE year = '" + year + "' AND belong_pro = '" + proName + "' AND batch = '" + batch +
                "'AND special_name like '%" + specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、考生类型展示所有专业信息(包括专业名称)
        public DataTable GetSpecialLineByYearAndType(string year, string type, string specialName)
        {
            string sql = "SELECT * FROM specialline WHERE year = '" + year + "' AND type = '" + type +
                "'AND special_name like '%" + specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、考生类型和录取批次展示所有专业信息(包括专业名称)
        public DataTable GetSpecialLineByYearAndTypeAndBatch(string year, string type, string batch, string specialName)
        {
            string sql = "SELECT * FROM specialline WHERE year = '" + year + "' AND type = '" + type + "'AND batch = " +
                "'" + batch + "'AND special_name like '%" + specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、考生类型和所属地区展示所有专业信息(包括专业名称)
        public DataTable GetSpecialLineByYearAndTypeAndPro(string year, string type, string proName, string specialName)
        {
            string sql = "SELECT u_name,special_name,local_province_name,type,year,batch,average_score,min_score FROM " +
                "view_specialline WHERE year = '" + year + "' AND type = '" + type + "' AND belong_pro = '" + proName +
                "'AND special_name like '%" + specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion

        #region 根据年份、考生类型、所属地区和录取批次展示所有专业信息(包括专业名称)
        public DataTable GetSpecialLineByYearAndTypeAndProAndBatch(string year, string type, string proName, string batch, string specialName)
        {
            string sql = "SELECT u_name,special_name,local_province_name,type,year,batch,average_score,min_score FROM " +
                "view_specialline WHERE year = '" + year + "' AND type = '" + type + "' AND belong_pro = '" + proName + "'" +
                "AND batch = '" + batch + "'AND special_name like '%" + specialName + "%'";
            return PgHelper.ExcuteDataTable(sql);
        }
        #endregion
    }
}

