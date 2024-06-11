using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Customer
{
    public Guid Id { get; set; }

    public bool? Active { get; set; }

    public string? Admincomment { get; set; }

    public Guid? Affiliateid { get; set; }

    public Guid? BillingaddressId { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerguid { get; set; }

    public bool? Deleted { get; set; }

    public string? Email { get; set; }

    public bool? Hasshoppingcartitems { get; set; }

    public bool? Issystemaccount { get; set; }

    public bool? Istaxexempt { get; set; }

    public DateTime? Lastactivitydateutc { get; set; }

    public string? Lastipaddress { get; set; }

    public DateTime? Lastlogindateutc { get; set; }

    public string? Password { get; set; }

    public Guid? Passwordformatid { get; set; }

    public string? Passwordsalt { get; set; }

    public Guid? ShippingaddressId { get; set; }

    public string? Systemname { get; set; }

    public string? Username { get; set; }

    public Guid? Vendorid { get; set; }

    public virtual ICollection<Activitylog> Activitylogs { get; set; } = new List<Activitylog>();

    public virtual ICollection<Backinstocksubscription> Backinstocksubscriptions { get; set; } = new List<Backinstocksubscription>();

    public virtual Address? Billingaddress { get; set; }

    public virtual ICollection<Blogcomment> Blogcomments { get; set; } = new List<Blogcomment>();

    public virtual ICollection<Externalauthenticationrecord> Externalauthenticationrecords { get; set; } = new List<Externalauthenticationrecord>();

    public virtual ICollection<ForumsPost> ForumsPosts { get; set; } = new List<ForumsPost>();

    public virtual ICollection<ForumsPrivatemessage> ForumsPrivatemessageFromcustomers { get; set; } = new List<ForumsPrivatemessage>();

    public virtual ICollection<ForumsPrivatemessage> ForumsPrivatemessageTocustomers { get; set; } = new List<ForumsPrivatemessage>();

    public virtual ICollection<ForumsSubscription> ForumsSubscriptions { get; set; } = new List<ForumsSubscription>();

    public virtual ICollection<ForumsTopic> ForumsTopics { get; set; } = new List<ForumsTopic>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual ICollection<Newscomment> Newscomments { get; set; } = new List<Newscomment>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Pollvotingrecord> Pollvotingrecords { get; set; } = new List<Pollvotingrecord>();

    public virtual ICollection<Productreview> Productreviews { get; set; } = new List<Productreview>();

    public virtual ICollection<Returnrequest> Returnrequests { get; set; } = new List<Returnrequest>();

    public virtual ICollection<Rewardpointshistory> Rewardpointshistories { get; set; } = new List<Rewardpointshistory>();

    public virtual Address? Shippingaddress { get; set; }

    public virtual ICollection<Shoppingcartitem> Shoppingcartitems { get; set; } = new List<Shoppingcartitem>();
}
