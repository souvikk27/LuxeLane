using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Manufacturer
{
    public Guid Id { get; set; }

    public bool? Allowcustomerstoselectpagesize { get; set; }

    public DateTime? Createdonutc { get; set; }

    public bool? Deleted { get; set; }

    public string? Description { get; set; }

    public int? Displayorder { get; set; }

    public bool? Limitedtostores { get; set; }

    public Guid? Manufacturertemplateid { get; set; }

    public string? Metadescription { get; set; }

    public string? Metakeywords { get; set; }

    public string? Metatitle { get; set; }

    public string? Name { get; set; }

    public long? Pagesize { get; set; }

    public string? Pagesizeoptions { get; set; }

    public Guid? Pictureid { get; set; }

    public string? Priceranges { get; set; }

    public bool? Published { get; set; }

    public bool? Subjecttoacl { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public virtual ICollection<ProductManufacturerMapping> ProductManufacturerMappings { get; set; } = new List<ProductManufacturerMapping>();
}
