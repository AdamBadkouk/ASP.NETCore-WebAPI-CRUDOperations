using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WebApi.Entities
{
    public class Product
    {
     
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
    }
}
