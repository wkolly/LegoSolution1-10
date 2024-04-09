using System;
using System.Collections.Generic;

namespace LegoSolution1_10.Models;

public partial class Order
{
    public string? TransactionId { get; set; }

    public string? CustomerId { get; set; }

    public string? Date { get; set; }

    public string? DayOfWeek { get; set; }

    public string? Time { get; set; }

    public string? EntryMode { get; set; }

    public string? Amount { get; set; }

    public string? TypeOfTransaction { get; set; }

    public string? CountryOfTransaction { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Bank { get; set; }

    public string? TypeOfCard { get; set; }

    public string? Fraud { get; set; }
}
