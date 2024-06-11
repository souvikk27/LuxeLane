using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Download
{
    public Guid Id { get; set; }

    public string? Contenttype { get; set; }

    public byte[]? Downloadbinary { get; set; }

    public Guid? Downloadguid { get; set; }

    public string? Downloadurl { get; set; }

    public string? Extension { get; set; }

    public string? Filename { get; set; }

    public bool? Isnew { get; set; }

    public bool? Usedownloadurl { get; set; }
}
