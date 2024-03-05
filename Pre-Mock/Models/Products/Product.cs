using Pre_Mock.Models.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_Mock.Models.Products
{
    public class Product
    {
        [Key]
        [Required]
        public Guid ProductId { get; set; }
        [Required(ErrorMessage ="Product name is required.")]
        [Column(TypeName ="nvarchar(50)")]
        public string ProductName { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        /*Composite Key*/
        public Guid BuyUserId {  get; set; }
        public ICollection<BuyUser>? BuyUsers { get; set; }
        /**/
        public float UnitStock { get; set; }
        public float UnitPrice { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Images { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayFormat(NullDisplayText ="No status")]
        public string Status { get; set;}
    }
}
