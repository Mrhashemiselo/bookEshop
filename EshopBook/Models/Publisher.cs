using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EshopBook.Models
{
    public class Publisher
    {
        public Publisher()
        {
            Books = new List<Books>();
        }

        [Key]
        public int PublisherId { get; set; }

        [Display(Name = "نام ناشر")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        public string PubisherName { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string PubisherDescription { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true , DataFormatString = "{0: yyyy/MM/dd}")]
        [Display(Name = "تاریخ تاسیس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime PublisherEstablished { get; set; }


        //Relation
        public List<Books> Books { get; set; }
    }
}
