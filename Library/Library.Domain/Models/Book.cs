using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class Book
    {
        public Book()
        {

        }

        [Key]
        public int BookID { get; set; }

        [Display(Name = "گروه کتاب")]
        public int GroupID { get; set; }

        [Display(Name = "نام کتاب")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(400)]
        public string BookName { get; set; }

        [Display(Name = "توضیح مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ShortDescription { get; set; }

        [Display(Name = "نام نویسنده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(400)]
        public string Author { get; set; }

        [Display(Name = "نام انتشارات")]
        [MaxLength(400)]
        public string PublisherName { get; set; }

        [Display(Name = "سال انتشار")]
        public DateTime PublishYear { get; set; }

        [Display(Name = "شماره سریال")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int ISBNNumber { get; set; }

        [Display(Name = "قیمت اجاره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Price { get; set; }

        [Display(Name = "تصویر")]
        public string ImageName { get; set; }

        [Display(Name = "نمایش در اسلایدر")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "بازدید")]
        public int BookVisit { get; set; }

        [Display(Name = "گروه")]
        public virtual BookGroup BookGroup { get; set; }

        public virtual List<Rent> Rents { get; set; }

    }
}
