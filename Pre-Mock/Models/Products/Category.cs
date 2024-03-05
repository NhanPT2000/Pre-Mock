using System.ComponentModel.DataAnnotations;

namespace Pre_Mock.Models.Products
{
    public class Category
    {
        [Key]
        [Required]
        public Guid CategoryId { get; set; }
        [Required()]
        public string CategoryName { get; set; }
        public string Status { get; set; }
    }
}
