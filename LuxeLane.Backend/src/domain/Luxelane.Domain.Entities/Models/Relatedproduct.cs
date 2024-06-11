using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Relatedproduct
{
    public Guid Id { get; set; }

    public int? Displayorder { get; set; }

    public Guid? Productid1 { get; set; }

    public Guid? Productid2 { get; set; }
}
