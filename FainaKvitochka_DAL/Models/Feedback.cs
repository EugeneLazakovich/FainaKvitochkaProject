using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_DAL.Models
{
    public class Feedback : BaseEntity
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDt { get; set; }
    }
}
