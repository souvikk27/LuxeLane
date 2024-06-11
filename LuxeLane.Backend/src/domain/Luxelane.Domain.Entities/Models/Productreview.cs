using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Productreview
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public int? Helpfulnototal { get; set; }

    public int? Helpfulyestotal { get; set; }

    public bool? Isapproved { get; set; }

    public Guid? Productid { get; set; }

    public int? Rating { get; set; }

    public string? Reviewtext { get; set; }

    public Guid? Storeid { get; set; }

    public string? Title { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ICollection<Productreviewhelpfulness> Productreviewhelpfulnesses { get; set; } = new List<Productreviewhelpfulness>();

    public virtual Store? Store { get; set; }
}
