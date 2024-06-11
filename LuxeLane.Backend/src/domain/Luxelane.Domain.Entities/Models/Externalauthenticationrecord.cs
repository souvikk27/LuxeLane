using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Externalauthenticationrecord
{
    public Guid Id { get; set; }

    public Guid? Customerid { get; set; }

    public string? Email { get; set; }

    public string? Externaldisplayidentifier { get; set; }

    public string? Externalidentifier { get; set; }

    public string? Oauthaccesstoken { get; set; }

    public string? Oauthtoken { get; set; }

    public string? Providersystemname { get; set; }

    public virtual Customer? Customer { get; set; }
}
