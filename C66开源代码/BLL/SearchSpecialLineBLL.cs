using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class SearchSpecialLineBLL
    {
        #region 常量、变量的定义
        private SearchSpecialLineDAL ssld = new SearchSpecialLineDAL();
        #endregion

        #region 根据专业名字查询专业录取线
        public DataTable SpecialLineGetBySpecialName(string specialName)
        {
            return ssld.GetSpecialLineBySpecialName(specialName);
        }
        #endregion

        #region 根据年份选择展示所有专业信息
        public DataTable SpecialLineGetByYear(string year)
        {
            return ssld.GetSpecialLineByYear(year);
        }
        #endregion

        #region 根据年份和批次展示所有专业信息
        public DataTable SpecialLineGetByYearAndBatch(string year, string batch)
        {
            return ssld.GetSpecialLineByYearAndBatch(year, batch);
        }
        #endregion

        #region 根据年份、所属地区展示所有专业信息
        public DataTable SpecialLineGetByYearAndPro(string year, string proName)
        {
            return ssld.GetSpecialLineByYearAndPro(year, proName);
        }
        #endregion

        #region 根据年份、所属地区和批次展示所有专业信息
        public DataTable SpecialLineGetByYearAndProAndBatch(string year, string proName, string batch)
        {
            return ssld.GetSpecialLineByYearAndProAndBatch(year, proName, batch);
        }
        #endregion

        #region 根据年份、考生类型展示所有专业信息
        public DataTable SpecialLineGetByYearAndType(string year, string type)
        {
            return ssld.GetSpecialLineByYearAndType(year, type);
        }
        #endregion

        #region 根据年份、考生类型和录取批次展示所有专业信息
        public DataTable SpecialLineGetByYearAndTypeAndBatch(string year, string type, string batch)
        {
            return ssld.GetSpecialLineByYearAndTypeAndBatch(year, type, batch);
        }
        #endregion

        #region 根据年份、考生类型和所属地区展示所有专业信息
        public DataTable SpecialLineGetByYearAndTypeAndPro(string year, string type, string proName)
        {
            return ssld.GetSpecialLineByYearAndTypeAndPro(year, type, proName);
        }
        #endregion

        #region 根据年份、考生类型、所属地区和录取批次展示所有专业信息
        public DataTable SpecialLineGetByYearAndTypeAndProAndBatch(string year, string type, string proName, string batch)
        {
            return ssld.GetSpecialLineByYearAndTypeAndProAndBatch(year, type, proName, batch);
        }
        #endregion


        #region 根据年份选择展示所有专业信息(包括专业名字)
        public DataTable SpecialLineGetByYear(string year, string specialName)
        {
            return ssld.GetSpecialLineByYear(year, specialName);
        }
        #endregion

        #region 根据年份和批次展示所有专业信息(包括专业名字)
        public DataTable SpecialLineGetByYearAndBatch(string year, string batch, string specialName)
        {
            return ssld.GetSpecialLineByYearAndBatch(year, batch, specialName);
        }
        #endregion

        #region 根据年份、所属地区展示所有专业信息(包括专业名字)
        public DataTable SpecialLineGetByYearAndPro(string year, string proName, string specialName)
        {
            return ssld.GetSpecialLineByYearAndPro(year, proName, specialName);
        }
        #endregion

        #region 根据年份、所属地区和批次展示所有专业信息(包括专业名字)
        public DataTable SpecialLineGetByYearAndProAndBatch(string year, string proName, string batch, string specialName)
        {
            return ssld.GetSpecialLineByYearAndProAndBatch(year, proName, batch, specialName);
        }
        #endregion

        #region 根据年份、考生类型展示所有专业信息(包括专业名字)
        public DataTable SpecialLineGetByYearAndType(string year, string type, string specialName)
        {
            return ssld.GetSpecialLineByYearAndType(year, type, specialName);
        }
        #endregion

        #region 根据年份、考生类型和录取批次展示所有专业信息(包括专业名字)
        public DataTable SpecialLineGetByYearAndTypeAndBatch(string year, string type, string batch, string specialName)
        {
            return ssld.GetSpecialLineByYearAndTypeAndBatch(year, type, batch, specialName);
        }
        #endregion

        #region 根据年份、考生类型和所属地区展示所有专业信息(包括专业名字)
        public DataTable SpecialLineGetByYearAndTypeAndPro(string year, string type, string proName, string specialName)
        {
            return ssld.GetSpecialLineByYearAndTypeAndPro(year, type, proName);
        }
        #endregion

        #region 根据年份、考生类型、所属地区和录取批次展示所有专业信息(包括专业名字)
        public DataTable SpecialLineGetByYearAndTypeAndProAndBatch(string year, string type, string proName, string batch, string specialName)
        {
            return ssld.GetSpecialLineByYearAndTypeAndProAndBatch(year, type, proName, batch, specialName);
        }
        #endregion
    }
}

