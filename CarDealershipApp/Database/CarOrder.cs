using System;
using System.Collections.Generic;

namespace CarDealershipApp.Database;

public partial class CarOrder
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? CarId { get; set; }

    public int? DealerId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Dealer? Dealer { get; set; }
}
