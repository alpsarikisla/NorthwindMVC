using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwindIleMVC.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Boş Bırakılamaz")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre Boş Bırakılamaz")]
        public string Password { get; set; }
    }
}