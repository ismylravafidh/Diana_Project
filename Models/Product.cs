namespace Diana_Project.Models
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }
        List<ProductColor>? ProductColors { get; set; }
        List<ProductSize>? ProductSizes { get; set; }
        List<ProductMaterial>? ProductMaterials { get; set; }
        List<Image>? Images { get; set; }
    }
}
