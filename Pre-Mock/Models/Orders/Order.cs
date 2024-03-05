using Pre_Mock.Models.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Pre_Mock.Models.Orders
{
    public class Order
    {
        [Key]
        [Required]
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid? UderId { get; set; }
        public User? User { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [DisplayFormat(NullDisplayText ="No status")]
        public string Status {  get; set; }
    }
}
