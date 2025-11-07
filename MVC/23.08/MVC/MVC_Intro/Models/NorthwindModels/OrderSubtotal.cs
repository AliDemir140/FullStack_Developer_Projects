using System;
using System.Collections.Generic;

namespace MVC_Intro.Models.NorthwindModels;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
