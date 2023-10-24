using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? UnitPrice { get; set; }

    public short? UnislnStock { get; set; }

    public int? CategoryId { get; set; }

    public virtual Caretory? Category { get; set; }
}
