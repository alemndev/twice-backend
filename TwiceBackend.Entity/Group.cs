using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class Group
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string? GroupKoreanName { get; set; }

    public string? GroupJapaneseName { get; set; }

    public string? GroupChineseName { get; set; }

    public string? GroupDescription { get; set; }

    public string? GroupOrigin { get; set; }

    public virtual ICollection<Discography> Discographies { get; set; } = new List<Discography>();

    public virtual ICollection<GroupFanclub> GroupFanclubs { get; set; } = new List<GroupFanclub>();

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
