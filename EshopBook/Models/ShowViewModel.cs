using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Models
{
    public class ShowViewModel
    {
        public Books Books { get; set; }
        public List<Group> Groups { get; set; }
    }
}
