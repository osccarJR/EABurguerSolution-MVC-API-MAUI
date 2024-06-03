using System;
using System.Collections.Generic;

namespace APIBurguerEA.Data.Models;

public partial class Promo
{
    public int PromoId { get; set; }

    public string? Descripcion { get; set; }

    public DateTime FechaPromo { get; set; }

    public int BurguerId { get; set; }

    public virtual Burguer Burguer { get; set; } = null!;
}
