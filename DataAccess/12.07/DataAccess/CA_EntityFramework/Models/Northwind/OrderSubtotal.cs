using System;
using System.Collections.Generic;

namespace CA_EntityFramework.Models.Northwind;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
