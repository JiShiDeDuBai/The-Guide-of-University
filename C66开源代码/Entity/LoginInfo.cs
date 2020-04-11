using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LoginInfo
    {
        #region 封装用户登陆名
        [Required(ErrorMessage = "用户名不能为空")]
        public string UserName { get; set; }
        #endregion

        #region 封装用户登陆密码
        [Required(ErrorMessage = "密码不能为空")]
        public string PassWord { get; set; } 
        #endregion
    }
}
