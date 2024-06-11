using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Checkoutattribute
{
    public Guid Id { get; set; }

    public Guid? Attributecontroltypeid { get; set; }

    public string? Conditionattributexml { get; set; }

    public string? Defaultvalue { get; set; }

    public int? Displayorder { get; set; }

    public bool? Isrequired { get; set; }

    public bool? Istaxexempt { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Name { get; set; }

    public bool? Shippableproductrequired { get; set; }

    public Guid? Taxcategoryid { get; set; }

    public string? Textprompt { get; set; }

    public string? Validationfileallowedextensions { get; set; }

    public int? Validationfilemaximumsize { get; set; }

    public int? Validationmaxlength { get; set; }

    public int? Validationminlength { get; set; }

    public virtual ICollection<Checkoutattributevalue> Checkoutattributevalues { get; set; } = new List<Checkoutattributevalue>();
}
