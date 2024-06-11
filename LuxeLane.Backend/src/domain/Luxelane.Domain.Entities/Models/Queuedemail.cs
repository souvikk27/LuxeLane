using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Queuedemail
{
    public Guid Id { get; set; }

    public Guid? Attacheddownloadid { get; set; }

    public string? Attachmentfilename { get; set; }

    public string? Attachmentfilepath { get; set; }

    public string? Bcc { get; set; }

    public string? Body { get; set; }

    public string? Cc { get; set; }

    public DateTime? Createdonutc { get; set; }

    public DateTime? Dontsendbeforedateutc { get; set; }

    public Guid? Emailaccountid { get; set; }

    public string? Fromemail { get; set; }

    public string? Fromname { get; set; }

    public Guid? Priorityid { get; set; }

    public string? Replyto { get; set; }

    public string? Replytoname { get; set; }

    public DateTime? Sentonutc { get; set; }

    public int? Senttries { get; set; }

    public string? Subject { get; set; }

    public string? Toemail { get; set; }

    public string? Toname { get; set; }

    public virtual Emailaccount? Emailaccount { get; set; }
}
