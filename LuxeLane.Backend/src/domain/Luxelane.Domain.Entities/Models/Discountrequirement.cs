using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Discountrequirement
{
    public Guid Id { get; set; }

    public Guid? Discountid { get; set; }

    public string? Discountrequirementrulesystemname { get; set; }

    public virtual Discount? Discount { get; set; }
}
