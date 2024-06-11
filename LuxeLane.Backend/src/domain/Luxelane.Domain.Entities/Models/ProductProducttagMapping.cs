using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class ProductProducttagMapping
{
    public Guid Id { get; set; }

    public Guid? ProducttagId { get; set; }

    public Guid? ProductId { get; set; }
}
