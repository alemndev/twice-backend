using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberSkill
{
    public int MemberId { get; set; }

    public string MemberSkill1 { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
