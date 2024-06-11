using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ForumsPrivatemessage
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Fromcustomerid { get; set; }

    public bool? Isdeletedbyauthor { get; set; }

    public bool? Isdeletedbyrecipient { get; set; }

    public bool? Isread { get; set; }

    public Guid? Storeid { get; set; }

    public string? Subject { get; set; }

    public string? Text { get; set; }

    public Guid? Tocustomerid { get; set; }

    public virtual Customer? Fromcustomer { get; set; }

    public virtual Customer? Tocustomer { get; set; }
}
