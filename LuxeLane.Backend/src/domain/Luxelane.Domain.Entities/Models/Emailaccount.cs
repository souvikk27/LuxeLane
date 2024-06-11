using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Emailaccount
{
    public Guid Id { get; set; }

    public string? Displayname { get; set; }

    public string? Email { get; set; }

    public bool? Enablessl { get; set; }

    public string? Host { get; set; }

    public string? Password { get; set; }

    public int? Port { get; set; }

    public bool? Usedefaultcredentials { get; set; }

    public string? Username { get; set; }

    public virtual ICollection<Queuedemail> Queuedemails { get; set; } = new List<Queuedemail>();
}
