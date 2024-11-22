using Pronia_P_1_1.Models.Base;

namespace Pronia_P_1_1.Models
{
    public class Tag:BaseEntity
    {
        public string Name { get; set; }
        public List<TagProduct> TagProducts { get; set; }

    }
}
