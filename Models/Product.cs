using System.ComponentModel.DataAnnotations;

namespace YourProject.Models
{
    // Represents a product in the product catalog
    public class Product
    {
        // The unique identifier of the product
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter a product price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please provide a proper price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please specify the availability of the product")]
        public bool IsAvailable { get; set; }

        // The category of the product
        [Required(ErrorMessage = "Please enter a product category")]
        public string Category { get; set; }

        // The URL to the product image
        public string ImageUrl { get; set; }
    }
}