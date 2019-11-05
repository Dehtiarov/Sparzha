using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ILoveSparzhaMVC.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Email { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public int Counter { get; set; } = 1;
    }

}