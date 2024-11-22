using Pronia_P_1_1.Models.Base;

namespace Pronia_P_1_1.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU  { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<TagProduct>TagProducts { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
