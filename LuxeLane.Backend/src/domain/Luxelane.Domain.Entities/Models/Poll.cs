using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Poll
{
    public Guid Id { get; set; }

    public bool? Allowgueststovote { get; set; }

    public int? Displayorder { get; set; }

    public DateTime? Enddateutc { get; set; }

    public Guid? Languageid { get; set; }

    public string? Name { get; set; }

    public bool? Published { get; set; }

    public bool? Showonhomepage { get; set; }

    public DateTime? Startdateutc { get; set; }

    public string? Systemkeyword { get; set; }

    public virtual Language? Language { get; set; }

    public virtual ICollection<Pollanswer> Pollanswers { get; set; } = new List<Pollanswer>();
}
