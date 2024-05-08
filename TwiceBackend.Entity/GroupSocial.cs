using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class GroupSocial
{
    public int GroupId { get; set; }

    public string GroupSocialName { get; set; } = null!;

    public string? GroupSocialUrl { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Group Group { get; set; } = null!;
}
