using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Pollvotingrecord
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Pollanswerid { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Pollanswer? Pollanswer { get; set; }
}
