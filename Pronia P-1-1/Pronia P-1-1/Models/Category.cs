using Pronia_P_1_1.Models.Base;

namespace Pronia_P_1_1.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public List<Product>Products { get; set; }
    }
}
