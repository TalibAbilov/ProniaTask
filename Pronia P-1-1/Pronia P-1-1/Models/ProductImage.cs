using Pronia_P_1_1.Models.Base;

namespace Pronia_P_1_1.Models
{
    public class ProductImage:BaseEntity
    {
        public string UrlImg { get; set; }
        public bool Primary { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
