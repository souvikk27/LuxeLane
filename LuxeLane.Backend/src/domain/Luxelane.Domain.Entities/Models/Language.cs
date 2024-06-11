using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Language
{
    public Guid Id { get; set; }

    public Guid? Defaultcurrencyid { get; set; }

    public int? Displayorder { get; set; }

    public string? Flagimagefilename { get; set; }

    public string? Languageculture { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Name { get; set; }

    public bool? Published { get; set; }

    public bool? Rtl { get; set; }

    public string? Uniqueseocode { get; set; }

    public virtual ICollection<Blogpost> Blogposts { get; set; } = new List<Blogpost>();

    public virtual ICollection<Localestringresource> Localestringresources { get; set; } = new List<Localestringresource>();

    public virtual ICollection<Localizedproperty> Localizedproperties { get; set; } = new List<Localizedproperty>();

    public virtual ICollection<News> News { get; set; } = new List<News>();

    public virtual ICollection<Poll> Polls { get; set; } = new List<Poll>();
}
