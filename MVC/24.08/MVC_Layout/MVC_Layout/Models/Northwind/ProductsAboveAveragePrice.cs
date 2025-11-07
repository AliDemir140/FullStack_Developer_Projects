using System;
using System.Collections.Generic;

namespace MVC_Layout.Models.Northwind;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
