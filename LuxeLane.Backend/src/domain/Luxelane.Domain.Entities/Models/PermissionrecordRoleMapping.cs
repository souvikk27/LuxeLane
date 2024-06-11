using System;
using System.Collections.Generic;

namespace Luxelane.Domain.Entities.Models;

public partial class PermissionrecordRoleMapping
{
    public Guid Customerroleid { get; set; }

    public Guid Permissionrecordid { get; set; }
}
