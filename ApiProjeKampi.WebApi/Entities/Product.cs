﻿namespace ApiProjeKampi.WebApi.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int imageUrl { get; set; }
    }
}
