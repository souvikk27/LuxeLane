using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ForumsTopic
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerid { get; set; }

    public Guid? Forumid { get; set; }

    public Guid? Lastpostcustomerid { get; set; }

    public Guid? Lastpostid { get; set; }

    public DateTime? Lastposttime { get; set; }

    public Guid? Numposts { get; set; }

    public string? Subject { get; set; }

    public Guid? Topictypeid { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public int? Views { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ForumsForum? Forum { get; set; }

    public virtual ICollection<ForumsPost> ForumsPosts { get; set; } = new List<ForumsPost>();
}
