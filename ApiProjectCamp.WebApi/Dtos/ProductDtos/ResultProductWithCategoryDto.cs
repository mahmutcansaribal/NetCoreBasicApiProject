using ApiProjectCamp.WebApi.Entities;

namespace ApiProjectCamp.WebApi.Dtos.ProductDtos
{
    public class ResultProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }

        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
