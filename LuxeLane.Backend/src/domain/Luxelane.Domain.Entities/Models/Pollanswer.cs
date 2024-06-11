using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Pollanswer
{
    public Guid Id { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }

    public int? Numberofvotes { get; set; }

    public Guid? Pollid { get; set; }

    public virtual Poll? Poll { get; set; }

    public virtual ICollection<Pollvotingrecord> Pollvotingrecords { get; set; } = new List<Pollvotingrecord>();
}
