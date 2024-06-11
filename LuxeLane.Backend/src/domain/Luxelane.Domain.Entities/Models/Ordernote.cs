using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Ordernote
{
    public DateTime? Createdonutc { get; set; }

    public bool? Displaytocustomer { get; set; }

    public Guid? Downloadid { get; set; }

    public Guid Id { get; set; }

    public string? Note { get; set; }

    public Guid? Orderid { get; set; }

    public virtual Order? Order { get; set; }
}
