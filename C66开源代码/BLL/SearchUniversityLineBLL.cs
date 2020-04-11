using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SearchUniversityLineBLL
    {
        #region 常量、变量的定义
        SearchUniversityLineDAL ssd = new SearchUniversityLineDAL();  //实例化一个DAL层对象用于方法的调用
        #endregion

        #region 通过用户输入的大学名称查找该大学对于各个省份的录取线信息
        public DataTable UniversityNameGet(string universityName)
        {
            return ssd.GetByUniversityName(universityName);
        }
        #endregion

        #region 查询某一年的所有大学分数信息
        public DataTable YearGet(string year)
        {
            return ssd.GetByYear(year);
        }
        #endregion

        #region 按批次查询某一年的分数信息
        public DataTable BatchAndYearGet(string batch, string year)
        {
            return ssd.GetByBatchAndYear(batch, year);
        }
        #endregion

        #region 查询某一省份的大学某一年的分数信息
        public DataTable ProAndYearGet(string proName, string year)
        {
            return ssd.GetByProAndYear(proName, year);
        }
        #endregion

        #region 按省份、录取批次查询某一年的分数信息
        public DataTable ProAndBatchAndYearGet(string proName, string batch, string year)
        {
            return ssd.GetByProAndBatchAndYear(proName, batch, year);
        }
        #endregion

        #region 查询不同类别在某一年的分数信息
        public DataTable TypeAndYearGet(string type, string year)
        {
            return ssd.GetByTypeAndYear(type, year);
        }
        #endregion

        #region 按类别、批次查询某一年的分数信息
        public DataTable TypeAndBatchAndYearGet(string type, string batch, string year)
        {
            return ssd.GetByTypeAndBatchAndYear(type, batch, year);
        }
        #endregion

        #region 查询某一省份某一类别某一年的分数信息
        public DataTable ProAndTypeAndYearGet(string proName, string type, string year)
        {
            return ssd.GetByProAndTypeAndYear(proName, type, year);
        }
        #endregion

        #region 按类别、省份、录取批次查询某一年的分数信息
        public DataTable TypeAndProAndBatchAndYearGet(string type, string proName, string batch, string year)
        {
            return ssd.GetByTypeAndProAndBatchAndYear(type, proName, batch, year);
        }
        #endregion


        #region 查询某一年的所有大学分数信息(包含大学名称)
        public DataTable YearAndNameGet(string year, string uName)
        {
            return ssd.GetByYearAndName(year, uName);
        }
        #endregion

        #region 按批次查询某一年的分数信息(包含大学名称)
        public DataTable BatchAndYearAndNameGet(string batch, string year, string uName)
        {
            return ssd.GetByBatchAndYearAndName(batch, year, uName);
        }
        #endregion

        #region 查询某一省份的大学某一年的分数信息(包含大学名称)
        public DataTable ProAndYearAndNameGet(string proName, string year, string uName)
        {
            return ssd.GetByProAndYearAndName(proName, year, uName);
        }
        #endregion

        #region 按省份、录取批次查询某一年的分数信息(包含大学名称)
        public DataTable ProAndBatchAndYearAndNameGet(string proName, string batch, string year, string uName)
        {
            return ssd.GetByProAndBatchAndYearAndName(proName, batch, year, uName);
        }
        #endregion

        #region 查询不同类别在某一年的分数信息(包含大学名称)
        public DataTable TypeAndYearAndNameGet(string type, string year, string uName)
        {
            return ssd.GetByTypeAndYearAndName(type, year, uName);
        }
        #endregion

        #region 按类别、批次查询某一年的分数信息(包含大学名称)
        public DataTable TypeAndBatchAndYearAndNameGet(string type, string batch, string year, string uName)
        {
            return ssd.GetByTypeAndBatchAndYearAndName(type, batch, year, uName);
        }
        #endregion

        #region 查询某一省份某一类别某一年的分数信息(包含大学名称)
        public DataTable ProAndTypeAndYearAndNameGet(string proName, string type, string year, string uName)
        {
            return ssd.GetByProAndTypeAndYearAndName(proName, type, year, uName);
        }
        #endregion

        #region 按类别、省份、录取批次查询某一年的分数信息(包含大学名称)
        public DataTable TypeAndProAndBatchAndYearAndNameGet(string type, string proName, string batch, string year, string uName)
        {
            return ssd.GetByTypeAndProAndBatchAndYearAndName(type, proName, batch, year, uName);
        }
        #endregion
    }
}
