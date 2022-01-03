using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Models
{
    public class Rent
    {
        public Rent()
        {

        }

        [Key]
        public int RentID { get; set; }

        [Display(Name = "کتاب")]
        public int BookID { get; set; }

        [Display(Name = "گروه")]
        public virtual Book Book { get; set; }

    }
}
