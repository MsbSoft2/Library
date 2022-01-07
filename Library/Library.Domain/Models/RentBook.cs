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
        [Key]
        public int RentID { get; set; }
        public int BookID { get; set; }
        public int UserId { get; set; }
        public DateTime GetDate { get; set; }
        public int CountDay { get; set; }


        public List<User> Users { get; set; }
        public List<Book> Books { get; set; }
    }
}
