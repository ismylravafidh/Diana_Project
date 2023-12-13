namespace Diana_Project.Models
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }
        List<ProductColor> ProductColors { get; set; }
    }
}
