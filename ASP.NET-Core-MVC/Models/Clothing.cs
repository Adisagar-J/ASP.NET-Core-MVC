using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core_MVC.Models
{
    public class Clothing
    {
        public int Id { get; set; }

        public string? ClothType { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Gender { get; set; }

        public decimal Price { get; set; }
    }
}
