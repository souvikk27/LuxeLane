using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Newslettersubscription
{
    public Guid Id { get; set; }

    public bool? Active { get; set; }

    public DateTime? Createdonutc { get; set; }

    public string? Email { get; set; }

    public Guid? Newslettersubscriptionguid { get; set; }

    public Guid? Storeid { get; set; }
}
