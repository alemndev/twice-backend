using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class User
{
    public int UserId { get; set; }

    public string UserNickname { get; set; } = null!;

    public string UserDisplayName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string? UserMail { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
