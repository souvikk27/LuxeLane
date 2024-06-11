using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Urlrecord
{
    public Guid Id { get; set; }

    public int? Entityid { get; set; }

    public string? Entityname { get; set; }

    public bool? Isactive { get; set; }

    public int? Languageid { get; set; }

    public string? Slug { get; set; }
}
