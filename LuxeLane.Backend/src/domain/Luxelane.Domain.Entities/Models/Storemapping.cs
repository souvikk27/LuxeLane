using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Storemapping
{
    public Guid Id { get; set; }

    public int? Entityid { get; set; }

    public string? Entityname { get; set; }

    public Guid? Storeid { get; set; }

    public virtual Store? Store { get; set; }
}
