using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Store
{
    public Guid Id { get; set; }

    public string? Companyaddress { get; set; }

    public string? Companyname { get; set; }

    public string? Companyphonenumber { get; set; }

    public string? Companyvat { get; set; }

    public Guid? Defaultlanguageid { get; set; }

    public int? Displayorder { get; set; }

    public string? Hosts { get; set; }

    public string? Name { get; set; }

    public string? Secureurl { get; set; }

    public bool? Sslenabled { get; set; }

    public string? Url { get; set; }

    public virtual ICollection<Productreview> Productreviews { get; set; } = new List<Productreview>();

    public virtual ICollection<Storemapping> Storemappings { get; set; } = new List<Storemapping>();
}
