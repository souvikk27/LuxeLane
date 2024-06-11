using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ForumsPostvote
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Forumpostid { get; set; }

    public bool? Isup { get; set; }

    public virtual ForumsPost? Forumpost { get; set; }
}
