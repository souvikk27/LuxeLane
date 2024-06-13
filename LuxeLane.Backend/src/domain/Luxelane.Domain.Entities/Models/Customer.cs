namespace Luxelane.Domain.Entities.Models;

public sealed partial class Customer
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

    public ICollection<Activitylog> Activitylogs { get; set; } = new List<Activitylog>();

    public ICollection<Backinstocksubscription> Backinstocksubscriptions { get; set; } = new List<Backinstocksubscription>();

    public Address? Billingaddress { get; set; }

    public ICollection<Blogcomment> Blogcomments { get; set; } = new List<Blogcomment>();

    public ICollection<Externalauthenticationrecord> Externalauthenticationrecords { get; set; } = new List<Externalauthenticationrecord>();

    public ICollection<ForumsPost> ForumsPosts { get; set; } = new List<ForumsPost>();

    public ICollection<ForumsPrivatemessage> ForumsPrivatemessageFromcustomers { get; set; } = new List<ForumsPrivatemessage>();

    public ICollection<ForumsPrivatemessage> ForumsPrivatemessageTocustomers { get; set; } = new List<ForumsPrivatemessage>();

    public ICollection<ForumsSubscription> ForumsSubscriptions { get; set; } = new List<ForumsSubscription>();

    public ICollection<ForumsTopic> ForumsTopics { get; set; } = new List<ForumsTopic>();

    public ICollection<Log> Logs { get; set; } = new List<Log>();

    public ICollection<Newscomment> Newscomments { get; set; } = new List<Newscomment>();

    public ICollection<Order> Orders { get; set; } = new List<Order>();

    public ICollection<Pollvotingrecord> Pollvotingrecords { get; set; } = new List<Pollvotingrecord>();

    public ICollection<Productreview> Productreviews { get; set; } = new List<Productreview>();

    public ICollection<Returnrequest> Returnrequests { get; set; } = new List<Returnrequest>();

    public ICollection<Rewardpointshistory> Rewardpointshistories { get; set; } = new List<Rewardpointshistory>();

    public Address? Shippingaddress { get; set; }

    public ICollection<Shoppingcartitem> Shoppingcartitems { get; set; } = new List<Shoppingcartitem>();
}
