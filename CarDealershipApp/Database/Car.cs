using System;
using System.Collections.Generic;

namespace CarDealershipApp.Database;

public partial class Car
{
    public int Id { get; set; }

    public string? Brand { get; set; }

    public string? Model { get; set; }

    public string? Year { get; set; }

    public string? Price { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<CarOrder> CarOrders { get; } = new List<CarOrder>();
}
