using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Topic
{
    public Guid Id { get; set; }

    public bool? Accessiblewhenstoreclosed { get; set; }

    public string? Body { get; set; }

    public int? Displayorder { get; set; }

    public bool? Includeinfootercolumn1 { get; set; }

    public bool? Includeinfootercolumn2 { get; set; }

    public bool? Includeinfootercolumn3 { get; set; }

    public bool? Includeinsitemap { get; set; }

    public bool? Includeintopmenu { get; set; }

    public bool? Ispasswordprotected { get; set; }

    public bool? Limitedtostores { get; set; }

    public string? Metadescription { get; set; }

    public string? Metakeywords { get; set; }

    public string? Metatitle { get; set; }

    public string? Password { get; set; }

    public bool? Published { get; set; }

    public bool? Subjecttoacl { get; set; }

    public string? Systemname { get; set; }

    public string? Title { get; set; }

    public Guid? Topictemplateid { get; set; }
}
