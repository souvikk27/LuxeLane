using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class Giftcardusagehistory
{
    public Guid Id { get; set; }

    public DateTime? Createdonutc { get; set; }

    public Guid? Giftcardid { get; set; }

    public decimal? Usedvalue { get; set; }

    public Guid? Usedwithorderid { get; set; }

    public virtual Giftcard? Giftcard { get; set; }

    public virtual Order? Usedwithorder { get; set; }
}
