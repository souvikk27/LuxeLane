using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Picture
{
    public Guid Id { get; set; }

    public string? Altattribute { get; set; }

    public bool? Isnew { get; set; }

    public string? Mimetype { get; set; }

    public byte[]? Picturebinary { get; set; }

    public string? Seofilename { get; set; }

    public string? Titleattribute { get; set; }

    public virtual ICollection<ProductPictureMapping> ProductPictureMappings { get; set; } = new List<ProductPictureMapping>();
}
