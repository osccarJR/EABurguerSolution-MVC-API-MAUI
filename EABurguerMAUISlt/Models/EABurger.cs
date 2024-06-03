using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EABurguerMAUISlt.Models
{
    public class EABurger
    {
        public int BurguerId { get; set; }
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        public decimal Precio { get; set; }
        public object[]? Promos { get; set; }
    }
}
