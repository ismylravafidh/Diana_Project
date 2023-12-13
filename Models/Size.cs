namespace Diana_Project.Models
{
    public class Size : BaseEntity
    {
        public string Name { get; set; }
        List<ProductSize> ProductSizes { get; set; }
    }
}
