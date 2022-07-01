using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام گروه")]
        public string GroupName { get; set; }

        [Display(Name = "توضیحات")]
        public string GroupDescription { get; set; }

        // Relation
        public ICollection<GroupToBook> GroupToBooks { get; set; }
    }
}
