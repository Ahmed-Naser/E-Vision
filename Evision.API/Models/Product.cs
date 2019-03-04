using System;

namespace Evision.API.Models
{
    public class Product
    {
          public int Id { get; set; }
          public string Name { get; set; }
          public decimal Price { get; set; }
          public DateTime LastUpdated { get; set; }      
    }
}