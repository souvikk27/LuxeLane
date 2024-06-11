using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Genericattribute
{
    public Guid Id { get; set; }

    public Guid? Entityid { get; set; }

    public string? Keyname { get; set; }

    public string? Keygroup { get; set; }

    public Guid? Storeid { get; set; }

    public string? Value { get; set; }
}
