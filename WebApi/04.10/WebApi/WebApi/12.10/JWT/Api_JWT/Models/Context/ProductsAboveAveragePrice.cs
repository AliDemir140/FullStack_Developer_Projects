using System;
using System.Collections.Generic;

namespace Api_JWT.Models.Context;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
