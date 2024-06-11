using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Messagetemplate
{
    public Guid Id { get; set; }

    public Guid? Attacheddownloadid { get; set; }

    public string? Bccemailaddresses { get; set; }

    public string? Body { get; set; }

    public int? Delaybeforesend { get; set; }

    public Guid? Delayperiodid { get; set; }

    public Guid? Emailaccountid { get; set; }

    public bool? Isactive { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Name { get; set; }

    public string? Subject { get; set; }
}
