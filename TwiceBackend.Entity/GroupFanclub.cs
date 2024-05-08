using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class GroupFanclub
{
    public int GroupFanclubId { get; set; }

    public string GroupFanclubName { get; set; } = null!;

    public string? GroupFanclubDescription { get; set; }

    public int GroupId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Group Group { get; set; } = null!;
}
