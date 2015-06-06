using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CgsSite.Web.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "请输入账号。")]
        [Display(Name="用户名")]
        public string AccountName { get; set; }
        [Required(ErrorMessage = "请输入密码。")]
        [Display(Name="密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name="记住我")]
        public bool RememberMe { get; set; }
    }
}