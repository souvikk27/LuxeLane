using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class News
{
    public Guid Id { get; set; }

    public bool? Allowcomments { get; set; }

    public int? Commentcount { get; set; }

    public DateTime? Createdonutc { get; set; }

    public DateTime? Enddateutc { get; set; }

    public string? Fullnews { get; set; }

    public Guid? Languageid { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Metadescription { get; set; }

    public string? Metakeywords { get; set; }

    public string? Metatitle { get; set; }

    public bool? Published { get; set; }

    public string? Short { get; set; }

    public DateTime? Startdateutc { get; set; }

    public string? Title { get; set; }

    public virtual Language? Language { get; set; }

    public virtual ICollection<Newscomment> Newscomments { get; set; } = new List<Newscomment>();
}
