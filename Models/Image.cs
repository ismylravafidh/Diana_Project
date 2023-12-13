namespace Diana_Project.Models
{
    public class Image : BaseEntity
    {
        public string ImgUrl { get; set; }
        public bool? IsPrime { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
