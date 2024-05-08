using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class UserRole
{
    public int UserId { get; set; }

    public int RolId { get; set; }

    public string RolName { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
