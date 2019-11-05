using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ILoveSparzhaMVC.Models
{
    public class AddUserViewModel
    {
        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "Максимальная длинна имейла 100 симвлов")]
        [Required(ErrorMessage = "Обязательное поле")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Не корректныей имеил адрес")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Максимальная длинна имени 100 сивлов")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }

    }
}