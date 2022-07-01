using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Models
{
    public class IndexViewModel
    {
        public List<Books> Books { get; set; }
        public List<Group> Group { get; set; }
        public List<BestBookViewModel> BestBooks { get; set; }
    }
}
