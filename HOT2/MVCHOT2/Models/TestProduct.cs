using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace MVCHOT2.Models
{
    public class TestProduct
    {
        public int TestProductId { get; set; }

        [Required(ErrorMessage = "Please enter a Product Name")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Short Description")]
        public string ProductDescShort { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Long Description")]
        public string ProductDescLong { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please submit an Image")]
        public string ProductImage { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Price for the product")]
        [Range(1, 100000,ErrorMessage ="Price must be a positive number, greater than 1")]
        public double ProductPrice { get; set; } = 0;

        [Required(ErrorMessage = "Please enter a Quantity")]
        [Range(1, 1000, ErrorMessage = "Quantity must be a positive number, greater than 1")]
        public int ProductQuantity { get; set; } = 0;

        public string Slug => ProductName?.Replace(' ', '-').ToLower() + '-' + ProductName?.Replace(' ', '-').ToLower();

        [Required(ErrorMessage = "Please select a product category")]
        public string CategoryId { get; set; } = string.Empty;

        [ValidateNever]
        public Category Category { get; set; } = null!;
    }
}
