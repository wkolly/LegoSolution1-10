﻿using System;
using System.Collections.Generic;

namespace LegoSolution1_10.Models;

public partial class LineItem
{
    public int TransactionId { get; set; }

    public int ProductId { get; set; }

    public int? Qty { get; set; }

    public int? Rating { get; set; }
}
