using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Aclrecord
{
    public Guid Id { get; set; }

    public Guid? Customerroleid { get; set; }

    public Guid? Entityid { get; set; }

    public string? Entityname { get; set; }

    public virtual Customerrole? Customerrole { get; set; }
}
