﻿namespace Diana_Project.Areas.Manage.ViewModels.Product
{
    public class UpdateProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<int>? ColorIds { get; set; }
        public List<int>? MaterialIds { get; set; }
        public List<int>? SizeIds { get; set; }
        public IFormFile? MainImage { get; set; }
        public List<IFormFile>? Images { get; set; }
        public List<ProductImagesVm>? productImages { get; set; }
        public List<int>? ImageIds { get; set; }
    }
    public class ProductImagesVm
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public bool? IsImage { get; set; }
    }
}
