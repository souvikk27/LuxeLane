using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ProductProductattributeMapping
{
    public Guid Id { get; set; }

    public Guid? Attributecontroltypeid { get; set; }

    public string? Conditionattributexml { get; set; }

    public string? Defaultvalue { get; set; }

    public int? Displayorder { get; set; }

    public bool? Isrequired { get; set; }

    public Guid? Productattributeid { get; set; }

    public Guid? Productid { get; set; }

    public string? Textprompt { get; set; }

    public string? Validationfileallowedextensions { get; set; }

    public int? Validationfilemaximumsize { get; set; }

    public int? Validationmaxlength { get; set; }

    public int? Validationminlength { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Productattribute? Productattribute { get; set; }

    public virtual ICollection<Productattributevalue> Productattributevalues { get; set; } = new List<Productattributevalue>();
}
