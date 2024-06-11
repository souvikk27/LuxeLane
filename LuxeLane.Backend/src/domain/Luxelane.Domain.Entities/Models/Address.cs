using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Address
{
    public Guid Id { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? Company { get; set; }

    public Guid? Countryid { get; set; }

    public DateTime? Createdonutc { get; set; }

    public string? Customattributes { get; set; }

    public string? Email { get; set; }

    public string? Faxnumber { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Phonenumber { get; set; }

    public Guid? Stateprovinceid { get; set; }

    public string? Zippostalcode { get; set; }

    public virtual ICollection<Affiliate> Affiliates { get; set; } = new List<Affiliate>();

    public virtual Country? Country { get; set; }

    public virtual ICollection<Customer> CustomerBillingaddresses { get; set; } = new List<Customer>();

    public virtual ICollection<Customer> CustomerShippingaddresses { get; set; } = new List<Customer>();

    public virtual ICollection<Order> OrderBillingaddresses { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderPickupaddresses { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderShippingaddresses { get; set; } = new List<Order>();

    public virtual Stateprovince? Stateprovince { get; set; }
}
