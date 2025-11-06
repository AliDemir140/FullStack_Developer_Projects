using System;
using System.Collections.Generic;

namespace CA_Performance.Models.Northwind;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
