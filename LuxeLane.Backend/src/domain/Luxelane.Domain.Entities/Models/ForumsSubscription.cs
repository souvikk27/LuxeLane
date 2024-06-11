using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ForumsSubscription
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Forumid { get; set; }

    public Guid? Subscriptionguid { get; set; }

    public Guid? Topicid { get; set; }

    public virtual Customer? Customer { get; set; }
}
