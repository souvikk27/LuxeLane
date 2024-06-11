using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Localizedproperty
{
    public Guid Id { get; set; }

    public Guid? Entityid { get; set; }

    public Guid? Languageid { get; set; }

    public string? Localekey { get; set; }

    public string? Localekeygroup { get; set; }

    public string? Localevalue { get; set; }

    public virtual Language? Language { get; set; }
}
