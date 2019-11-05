using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ILoveSparzhaMVC.Models
{
    public class UserViewModel
    {
        [Display(Name = "Список любителей спаржи")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Дата")]
        [DisplayFormat(DataFormatString = "{0:HH.mm dd.MM.yyyy}")]
        public DateTime Date { get; set; }

        public int Counter { get; set; }
    }
}