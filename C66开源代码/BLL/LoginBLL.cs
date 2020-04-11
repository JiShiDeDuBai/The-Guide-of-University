using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        #region 常量、变量的定义
        LoginDAL ld = new LoginDAL();  //实例化一个DAL层的对象用于访问方法
        #endregion

        #region 检查用户登陆信息
        public bool CheckLogin(string userName, string passWord)
        {
            try
            {
                return ld.CheckLogin(userName, passWord);
            }
            catch(Exception e)
            {
                throw e;
            }
        } 
        #endregion
    }
}
