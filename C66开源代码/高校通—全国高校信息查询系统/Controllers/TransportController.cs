using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using BLL;

namespace 高校通_全国高校信息查询系统.Controllers
{
    public class TransportController : Controller
    {
        #region 常量、变量的定义
        SearchUniversityLineBLL uLine = new SearchUniversityLineBLL();
        SearchProLineBLL proLine = new SearchProLineBLL();
        SearchSpecialLineBLL specialLine = new SearchSpecialLineBLL();
        #endregion

        // GET: Transport
        public ActionResult Index()
        {
            return View();
        }

        #region DataTable类型的值转为JSON字符串
        /// <summary>
        /// DataTable转Json
        /// </summary>
        /// <param name="dtb"></param>
        /// <returns></returns>
        /// 这里实现将DataTable类型转为Josn类型再发送到前端
        private string Dtb2Json(DataTable dtb)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            jss.MaxJsonLength = Int32.MaxValue;
            ArrayList dic = new ArrayList();
            foreach (DataRow row in dtb.Rows)
            {
                Dictionary<string, object> drow = new Dictionary<string, object>();
                foreach (DataColumn col in dtb.Columns)
                {
                    drow.Add(col.ColumnName, row[col.ColumnName]);
                }
                dic.Add(drow);
            }

            return jss.Serialize(dic);
        }
        #endregion

        #region JSON字符串转为DataTable类型的值
        /// <summary>
        /// Json转DataTable
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        /// json转为datatable
        private DataTable Json2Dtb(string json)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            ArrayList dic = jss.Deserialize<ArrayList>(json);
            DataTable dtb = new DataTable();

            if (dic.Count > 0)
            {
                foreach (Dictionary<string, object> drow in dic)
                {
                    if (dtb.Columns.Count == 0)
                    {
                        foreach (string key in drow.Keys)
                        {
                            dtb.Columns.Add(key, drow[key].GetType());
                        }
                    }

                    DataRow row = dtb.NewRow();
                    foreach (string key in drow.Keys)
                    {

                        row[key] = drow[key];
                    }
                    dtb.Rows.Add(row);
                }
            }
            return dtb;
        }
        #endregion

        #region 查省线
        public ActionResult GetProLine(string proName, string year, string type, string batch)
        {
            try
            {
                string back = "";
                if (batch != "全部" && type != "全部")
                {
                    back = Dtb2Json(proLine.ProLineGet(proName, year, type, batch));
                }
                else if(batch == "全部" && type != "全部")
                {
                    back = Dtb2Json(proLine.ProLineGet1(proName, year, type));
                }
                else if(batch != "全部" && type == "全部")
                {
                    back = Dtb2Json(proLine.ProLineGet2(proName, year, batch));
                }
                else if(batch == "全部" && type == "全部")
                {
                    back = Dtb2Json(proLine.ProLineGet(proName, year));
                }
                
                return Content(back);
            }
            catch(Exception e)
            {
                return Content(e.ToString());
            }
        }
        #endregion

        #region 通过用户输入的大学名称查找该大学对于各个省份的录取线信息
        public ActionResult GetUniversityLineByName(string universityName)
        {
            try
            {
                string back = Dtb2Json(uLine.UniversityNameGet(universityName));
                return Content(back);   //将转换完成的数据返回。
            }
            catch(Exception e)
            {
                return Content(e.ToString());//异常处理
            }

        }
        #endregion

        #region 查大学分数线
        public ActionResult GetUniversityLine(string type, string proName, string batch, string year, string uName)
        {
            try
            {
                string back = "";
                if (uName == "")
                {
                    if (type == "全部" && proName == "全部" && batch == "全部") //查询某一年份的分数信息
                    {
                        back = Dtb2Json(uLine.YearGet(year));
                    }
                    else if (type == "全部" && proName == "全部" && batch != "全部") //按批次查询某一年的分数信息
                    {
                        back = Dtb2Json(uLine.BatchAndYearGet(batch, year));
                    }
                    else if (type == "全部" && proName != "全部" && batch == "全部") //查询某一省份的大学某一年的分数信息
                    {
                        back = Dtb2Json(uLine.ProAndYearGet(proName, year));
                    }
                    else if (type == "全部" && proName != "全部" && batch != "全部") //按省份、录取批次查询某一年的分数信息
                    {
                        back = Dtb2Json(uLine.ProAndBatchAndYearGet(proName, batch, year));
                    }
                    else if (type != "全部" && proName == "全部" && batch == "全部") //查询不同类别在某一年的分数信息
                    {
                        back = Dtb2Json(uLine.TypeAndYearGet(type, year));
                    }
                    else if (type != "全部" && proName == "全部" && batch != "全部") //按类别、批次查询某一年的分数信息
                    {
                        back = Dtb2Json(uLine.TypeAndBatchAndYearGet(type, batch, year));
                    }
                    else if (type != "全部" && proName != "全部" && batch == "全部") //查询某一省份某一类别某一年的分数信息
                    {
                        back = Dtb2Json(uLine.ProAndTypeAndYearGet(proName, type, year));
                    }
                    else if (type != "全部" && proName != "全部" && batch != "全部") //按类别、省份、录取批次查询某一年的分数信息
                    {
                        back = Dtb2Json(uLine.TypeAndProAndBatchAndYearGet(type, proName, batch, year));
                    }
                }
                else
                {
                    if (type == "全部" && proName == "全部" && batch == "全部") //查询某一年份的分数信息
                    {
                        back = Dtb2Json(uLine.YearAndNameGet(year, uName));
                    }
                    else if (type == "全部" && proName == "全部" && batch != "全部") //按批次查询某一年的分数信息
                    {
                        back = Dtb2Json(uLine.BatchAndYearAndNameGet(batch, year, uName));
                    }
                    else if (type == "全部" && proName != "全部" && batch == "全部") //查询某一省份的大学某一年的分数信息
                    {
                        back = Dtb2Json(uLine.ProAndYearAndNameGet(proName, year, uName));
                    }
                    else if (type == "全部" && proName != "全部" && batch != "全部") //按省份、录取批次查询某一年的分数信息
                    {
                        back = Dtb2Json(uLine.ProAndBatchAndYearAndNameGet(proName, batch, year, uName));
                    }
                    else if (type != "全部" && proName == "全部" && batch == "全部") //查询不同类别在某一年的分数信息
                    {
                        back = Dtb2Json(uLine.TypeAndYearAndNameGet(type, year, uName));
                    }
                    else if (type != "全部" && proName == "全部" && batch != "全部") //按类别、批次查询某一年的分数信息
                    {
                        back = Dtb2Json(uLine.TypeAndBatchAndYearAndNameGet(type, batch, year, uName));
                    }
                    else if (type != "全部" && proName != "全部" && batch == "全部") //查询某一省份某一类别某一年的分数信息
                    {
                        back = Dtb2Json(uLine.ProAndTypeAndYearAndNameGet(proName, type, year, uName));
                    }
                    else if (type != "全部" && proName != "全部" && batch != "全部") //按类别、省份、录取批次查询某一年的分数信息
                    {
                        back = Dtb2Json(uLine.TypeAndProAndBatchAndYearAndNameGet(type, proName, batch, year, uName));
                    }
                }

                return Content(back);
            }
            catch (Exception e)
            {
                return Content(e.ToString());
            }
        } 
        #endregion

        #region 查专业线
        public ActionResult GetSpecialLine(string type, string proName, string batch, string year, string specialName)
        {
            try
            {
                string back = "";
                if (specialName == "")
                {
                    if (type == "全部" && proName == "全部" && batch == "全部") //根据年份选择展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYear(year));
                    }
                    else if (type == "全部" && proName == "全部" && batch != "全部") //根据年份和批次展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndBatch(year, batch));
                    }
                    else if (type == "全部" && proName != "全部" && batch == "全部") //根据年份、所属地区展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndPro(year, proName));
                    }
                    else if (type == "全部" && proName != "全部" && batch != "全部") //根据年份、所属地区和批次展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndProAndBatch(year, proName, batch));
                    }
                    else if (type != "全部" && proName == "全部" && batch == "全部") //根据年份、考生类型展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndType(year, type));
                    }
                    else if (type != "全部" && proName == "全部" && batch != "全部") //根据年份、考生类型和录取批次展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndTypeAndBatch(year, type, batch));
                    }
                    else if (type != "全部" && proName != "全部" && batch == "全部") //根据年份、考生类型和所属地区展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndTypeAndPro(year, type, proName));
                    }
                    else if (type != "全部" && proName != "全部" && batch != "全部") //根据年份、考生类型、所属地区和录取批次展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndTypeAndProAndBatch(year, type, proName, batch));
                    }
                }
                else
                {
                    if (type == "全部" && proName == "全部" && batch == "全部") //根据年份选择展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYear(year, specialName));
                    }
                    else if (type == "全部" && proName == "全部" && batch != "全部") //根据年份和批次展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndBatch(year, batch, specialName));
                    }
                    else if (type == "全部" && proName != "全部" && batch == "全部") //根据年份、所属地区展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndPro(year, proName, specialName));
                    }
                    else if (type == "全部" && proName != "全部" && batch != "全部") //根据年份、所属地区和批次展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndProAndBatch(year, proName, batch, specialName));
                    }
                    else if (type != "全部" && proName == "全部" && batch == "全部") //根据年份、考生类型展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndType(year, type, specialName));
                    }
                    else if (type != "全部" && proName == "全部" && batch != "全部") //根据年份、考生类型和录取批次展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndTypeAndBatch(year, type, batch, specialName));
                    }
                    else if (type != "全部" && proName != "全部" && batch == "全部") //根据年份、考生类型和所属地区展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndTypeAndPro(year, type, proName, specialName));
                    }
                    else if (type != "全部" && proName != "全部" && batch != "全部") //根据年份、考生类型、所属地区和录取批次展示所有专业信息
                    {
                        back = Dtb2Json(specialLine.SpecialLineGetByYearAndTypeAndProAndBatch(year, type, proName, batch, specialName));
                    }
                }


                return Content(back);
            }
            catch (Exception e)
            {
                return Content(e.ToString());
            }
        }
        #endregion
      
        #region 通过用户输入的专业名称查找所有该专业的录取线信息
        public ActionResult GetSpecialLineByName(string specialName)
        {
            try
            {
                string back = Dtb2Json(specialLine.SpecialLineGetBySpecialName(specialName));
                return Content(back);   //将转换完成的数据返回。
            }
            catch (Exception e)
            {
                return Content(e.ToString());//异常处理
            }

        }
        #endregion
    }
}