using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Models
{
    public class GroupToBook
    {
        [Key]
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int BookId { get; set; }

        //Relation
        public Group Group { get; set; }
        public Books Books { get; set; }
    }
}
