using System;
using System.Collections.Generic;

namespace NorthwindSingleton.Models;

public partial class Table1
{
    public int Id { get; set; }

    public int Table2Id { get; set; }

    public virtual Table2 Table2 { get; set; } = null!;
}
