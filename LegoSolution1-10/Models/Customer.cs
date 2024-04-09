using System;
using System.Collections.Generic;

namespace LegoSolution1_10.Models;

public partial class Customer
{
    public string? CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? CountryOfResidence { get; set; }

    public string? Gender { get; set; }

    public decimal? Age { get; set; }
}
