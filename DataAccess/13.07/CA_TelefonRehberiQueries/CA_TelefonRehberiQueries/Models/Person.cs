using System;
using System.Collections.Generic;

namespace CA_TelefonRehberiQueries.Models;

public partial class Person
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
}
