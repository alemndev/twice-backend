using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberNickname
{
    public int MemberId { get; set; }

    public string MemberNickname1 { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Member Member { get; set; } = null!;
}
