using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Models
{
    public class BestBookViewModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int GroupId { get; set; }
        public string Groupname { get; set; }
        public int countOfBook { get; set; }
    }
}
