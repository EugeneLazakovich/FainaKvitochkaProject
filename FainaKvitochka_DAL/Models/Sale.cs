using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FainaKvitochka_DAL.Models
{
    public class Sale : BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public TypeOfDelivery TypeOfDelivery { get; set; }
        public string Address { get; set; }
        public TypeOfPay TypeOfPay { get; set; }
        public double Cost { get; set; }
        [ForeignKey("Client")]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public bool IsNew { get; set; }
    }
}
