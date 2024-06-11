using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ForumsGroup
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public virtual ICollection<ForumsForum> ForumsForums { get; set; } = new List<ForumsForum>();
}
