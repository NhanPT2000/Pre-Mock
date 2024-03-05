using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pre_Mock.Models.Orders
{
    public class OrderDetails
    {
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public float UnitPrice { get; set; }
        public float UnitStock { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayFormat(NullDisplayText = "No status")]
        public string Status { get; set;}
    }
}
