using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;

namespace 高校通_全国高校信息查询系统.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        #region 常量、变量的定义
        LoginBLL lb = new LoginBLL();  //实例化一个BLL层的对象，用于访问BLL层的方法
        #endregion

        #region 检查用户登陆信息并将结果返回给前端
        public ActionResult CheckLogin(string userName, string passWord)
        {
            if (lb.CheckLogin(userName, passWord))
            {

                return Content("登陆成功");
            }
            else
            {
                return Content("Error");
            }
        } 
        #endregion
    }
}