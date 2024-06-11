using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ForumsForum
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public string? Description { get; set; }

    public int? Displayorder { get; set; }

    public Guid? Forumgroupid { get; set; }

    public Guid? Lastpostcustomerid { get; set; }

    public Guid? Lastpostid { get; set; }

    public DateTime? Lastposttime { get; set; }

    public Guid? Lasttopicid { get; set; }

    public string? Name { get; set; }

    public int? Numposts { get; set; }

    public int? Numtopics { get; set; }

    public DateTime? Updatedonutc { get; set; }

    public virtual ForumsGroup? Forumgroup { get; set; }

    public virtual ICollection<ForumsTopic> ForumsTopics { get; set; } = new List<ForumsTopic>();
}
