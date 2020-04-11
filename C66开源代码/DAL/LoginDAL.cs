using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        #region 检查用户登陆信息是否正确
        public bool CheckLogin(string userName, string passWord)
        {
            string sql = "SELECT * FROM user_info WHERE username = '" + userName + "'AND password = '" + passWord + "'";

            NpgsqlParameter[] paras =
            {
                new NpgsqlParameter("@username",userName),
                new NpgsqlParameter("@password",passWord)
            };

            return PgHelper.CheckLogin(sql, paras);
        }
    } 
    #endregion
}
