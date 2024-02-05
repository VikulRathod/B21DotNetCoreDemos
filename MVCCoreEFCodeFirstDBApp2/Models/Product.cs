using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCoreCodeFirstEFApp.Models
{
    [Table("tblProduct")]
    public class Product
    {
        [Key]  // primary key
        public int ProductId { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Column("UnitPrice")]
        public decimal Price { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }

        [NotMapped] // no column will get created for this property
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; } // navigation property
    }
}
