using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ForumsPost
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public string? Ipaddress { get; set; }

    public string? Text { get; set; }

    public Guid? Topicid { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public int? Votecount { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<ForumsPostvote> ForumsPostvotes { get; set; } = new List<ForumsPostvote>();

    public virtual ForumsTopic? Topic { get; set; }
}
