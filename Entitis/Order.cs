using System;
using System.Collections.Generic;

namespace Entitis;

public partial class Order
{
    public int Id { get; set; }

    public DateTime? OrderDate { get; set; }

    public double? OrderSum { get; set; }

    public int? UserId { get; set; }

    public virtual User? User { get; set; }
}
