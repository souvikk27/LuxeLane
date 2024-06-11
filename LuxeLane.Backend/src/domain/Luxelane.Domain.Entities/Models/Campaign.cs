namespace Luxelane.Domain.Entities.Models;

public partial class Campaign
{
    public Guid Id { get; set; }

    public string? Body { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Customerroleid { get; set; }

    public DateTime? Dontsendbeforedateutc { get; set; }

    public string? Name { get; set; }

    public Guid? Storeid { get; set; }

    public string? Subject { get; set; }
}
