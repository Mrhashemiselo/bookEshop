using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="نام کتاب")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شابک")]
        public string BookShabak { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام نویسنده")]
        public string BookAuthor { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy/MM/dd}")]
        [Display(Name = "تاریخ انتشار")]
        public DateTime BookRelease { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name = "قیمت")]
        public int BookPrice { get; set; }

        //تعداد بازدید های کتاب
        public int BookView { get; set; }
        public int PublisherId { get; set; }

        //Relation
        public ICollection<GroupToBook> GroupToBooks { get; set; }
        public Publisher Publisher { get; set; }
    }
}
