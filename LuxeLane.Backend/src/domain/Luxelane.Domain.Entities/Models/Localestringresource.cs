using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Localestringresource
{
    public Guid Id { get; set; }

    public Guid? Languageid { get; set; }

    public string? Resourcename { get; set; }

    public string? Resourcevalue { get; set; }

    public virtual Language? Language { get; set; }
}
