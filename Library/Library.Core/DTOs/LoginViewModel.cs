using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.DTOs
{
    public class LoginViewModel
    {
        [Display(Name = "نام کامل"), Required(ErrorMessage = "لطفا {0} را وارد کنید"), MaxLength(150)]
        public string FullName { get; set; }

        [Display(Name = "کلمه عبور"), Required(ErrorMessage = "لطفا {0} را وارد کنید"), MaxLength(150)]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RemmemberMe { get; set; }
    }
}
