using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_DAL.Models
{
    public class Color : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
