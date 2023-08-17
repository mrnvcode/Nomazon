using System;
using System.Collections.Generic;

namespace FinalExamAPI.models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Image { get; set; }

    public decimal? Price { get; set; }

    public int? StockInHand { get; set; }
}
