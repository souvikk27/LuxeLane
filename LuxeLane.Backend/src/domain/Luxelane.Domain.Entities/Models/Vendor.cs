using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Vendor
{
    public Guid Id { get; set; }

    public bool? Active { get; set; }

    public string? Admincomment { get; set; }

    public bool? Allowcustomerstoselectpagesize { get; set; }

    public bool? Deleted { get; set; }

    public string? Description { get; set; }

    public int? Displayorder { get; set; }

    public string? Email { get; set; }

    public string? Metadescription { get; set; }

    public string? Metakeywords { get; set; }

    public string? Metatitle { get; set; }

    public string? Name { get; set; }

    public int? Pagesize { get; set; }

    public string? Pagesizeoptions { get; set; }

    public Guid? Pictureid { get; set; }

    public virtual ICollection<Vendornote> Vendornotes { get; set; } = new List<Vendornote>();
}
