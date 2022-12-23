using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FainaKvitochka_DAL.Models
{
    public class Item : BaseEntity
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        [ForeignKey("Size")]
        public Guid SizeId { get; set; }
        public Size Size { get; set; }
        public ICollection<FilePath> FilePaths { get; set; }
        [ForeignKey("Form")]
        public Guid FormId { get; set; }
        public Form Form { get; set; }

    }
}
