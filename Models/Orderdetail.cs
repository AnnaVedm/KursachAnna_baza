﻿using System;
using System.Collections.Generic;

namespace KursachAnna.Models;

public partial class Orderdetail
{
    public int Orderdetailid { get; set; }

    public int Orderid { get; set; }

    public int Productid { get; set; }

    public int Quantity { get; set; }

    public decimal Unitprice { get; set; }

    public int? Userid { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual Useraccount? User { get; set; }
}
