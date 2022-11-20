using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_DAL.Models
{
    public class ItemColor : BaseEntity
    {
        [ForeignKey("Item")]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        [ForeignKey("Color")]
        public Guid ColorId { get; set; }
        public Color Color { get; set; }
    }
}
