﻿namespace Diana_Project.Models
{
    public class Material : BaseEntity
    {
        public string Name { get; set; }
        List<ProductMaterial> ProductMaterials { get; set; }
    }
}