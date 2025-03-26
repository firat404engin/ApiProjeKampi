using ApiProjeKampi.WebApi.Entities;

namespace ApiProjeKampi.WebApi.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string imageUrl { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
