﻿using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Deliverydate
{
    public Guid Id { get; set; }

    public int? Displayorder { get; set; }

    public string? Name { get; set; }
}
