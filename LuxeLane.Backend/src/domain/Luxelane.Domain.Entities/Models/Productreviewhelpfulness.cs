using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Productreviewhelpfulness
{
    public Guid Id { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Productreviewid { get; set; }

    public bool? Washelpful { get; set; }

    public virtual Productreview? Productreview { get; set; }
}
