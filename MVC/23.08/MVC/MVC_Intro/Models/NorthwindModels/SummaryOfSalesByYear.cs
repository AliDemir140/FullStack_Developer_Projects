using System;
using System.Collections.Generic;

namespace MVC_Intro.Models.NorthwindModels;

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
