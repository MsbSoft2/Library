using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Models
{
    public class User
    {
        [Key] public int Id { get; set; }

        [Display(Name = "نام کامل"), Required(ErrorMessage = "لطفا {0} را وارد کنید"), MaxLength(150)]
        public string FullName { get; set; }

        [Display(Name = "کلمه عبور"), Required(ErrorMessage = "لطفا {0} را وارد کنید"), MaxLength(150)]
        public string Password { get; set; }

        [Display(Name = "تاریخ عضویت")]
        public DateTime RegisterDate { get; set; }
    }
}