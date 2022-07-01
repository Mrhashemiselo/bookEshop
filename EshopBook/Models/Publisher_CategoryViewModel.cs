using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Models
{
    public class Publisher_CategoryViewModel
    {
        public int BookId { get; set; }

        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [Display(Name ="نام کتاب")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "شابک")]
        [MaxLength(13),MinLength(13)]
        public string BookShabak { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نویسنده کتاب")]
        public string BookAuthor { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "تاریخ انتشار")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true , DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime BookRelease { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "قیمت کتاب")]
        public int BookPrice { get; set; }

        [Display(Name = "تعداد بازدید")]
        public int BookView { get; set; }

        [Display(Name = "ناشر")]
        public List<Publisher> Publishers { get; set; }

        [Display(Name = "گروه")]
        public List<Group> Groups { get; set; }

        public int PublisherId { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام ناشر")]
        public string PublisherName { get; set; }

        public int GroupId { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Display(Name = "نام گروه")]
        public string GroupName { get; set; }
    }
}
