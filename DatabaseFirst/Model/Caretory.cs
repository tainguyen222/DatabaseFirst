using System;
using System.Collections.Generic;

namespace DatabaseFirst.Model;

public partial class Caretory
{
    public int CaretorytId { get; set; }

    public string? CaretoryName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
