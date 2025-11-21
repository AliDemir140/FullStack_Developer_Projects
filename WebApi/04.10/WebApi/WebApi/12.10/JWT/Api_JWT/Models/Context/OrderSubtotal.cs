using System;
using System.Collections.Generic;

namespace Api_JWT.Models.Context;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
