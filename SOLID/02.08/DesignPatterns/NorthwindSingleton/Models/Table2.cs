using System;
using System.Collections.Generic;

namespace NorthwindSingleton.Models;

public partial class Table2
{
    public int Id { get; set; }

    public virtual ICollection<Table1> Table1s { get; set; } = new List<Table1>();
}
