using System.ComponentModel.DataAnnotations;

namespace EABurguerSolution.Models
{
    public class Burguer
    {
        public int BurguerId { get; set; }
        [Required]
        public string Name { get; set; }
        public bool WithCheese { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
        public List<Promo>? Promo { get; set; }
    }
}