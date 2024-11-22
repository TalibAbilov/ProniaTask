using Pronia_P_1_1.Models.Base;

namespace Pronia_P_1_1.Models
{
    public class TagProduct:BaseEntity
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
    }
}
