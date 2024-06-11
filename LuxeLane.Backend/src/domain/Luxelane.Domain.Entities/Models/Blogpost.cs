using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Blogpost
{
    public Guid Id { get; set; }

    public bool? Allowcomments { get; set; }

    public string? Body { get; set; }

    public string? Bodyoverview { get; set; }

    public Guid? Commentcount { get; set; }

    public DateTime? Createdonutc { get; set; }

    public DateTime? Enddateutc { get; set; }

    public Guid? Languageid { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Metadescription { get; set; }

    public string? Metakeywords { get; set; }

    public string? Metatitle { get; set; }

    public DateTime? Startdateutc { get; set; }

    public string? Tags { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<Blogcomment> Blogcomments { get; set; } = new List<Blogcomment>();

    public virtual Language? Language { get; set; }
}
