using System;
using System.Collections.Generic;

namespace CarDealershipApp.Database;

public partial class Dealer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public string? Tel { get; set; }

    public virtual ICollection<CarOrder> CarOrders { get; } = new List<CarOrder>();
}
