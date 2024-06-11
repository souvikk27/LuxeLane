using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ProductPictureMapping
{
    public Guid Id { get; set; }

    public int? Displayorder { get; set; }

    public Guid? Pictureid { get; set; }

    public Guid? Productid { get; set; }

    public virtual Picture? Picture { get; set; }

    public virtual Product? Product { get; set; }
}
