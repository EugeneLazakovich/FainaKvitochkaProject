using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FainaKvitochka_DAL.Models
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
