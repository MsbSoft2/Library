using System;

namespace Library.Core.DTOs
{
    public class RentViewModel
    {
        public int RentID { get; set; }
        public string UserName { get; set; }
        public string BookName { get; set; }
        public int CountDay { get; set; }
        public int Price { get; set; }
        public DateTime RentDate { get; set; }
    }
}
