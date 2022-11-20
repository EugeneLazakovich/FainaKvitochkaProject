using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FainaKvitochka_DAL.Models
{
    public class ItemSale : BaseEntity
    {
        [ForeignKey("Item")]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
        [ForeignKey("Sale")]
        public Guid SaleId { get; set; }
        public Sale Sale { get; set; }
    }
}
