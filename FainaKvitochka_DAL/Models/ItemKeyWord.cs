using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FainaKvitochka_DAL.Models
{
    public class ItemKeyWord : BaseEntity
    {
        [ForeignKey("Item")]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        [ForeignKey("KeyWord")]
        public Guid KeyWordId { get; set; }
        public KeyWord KeyWord { get; set; }
    }
}
