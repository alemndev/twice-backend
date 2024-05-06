using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberHobbie
{
    public int MemberId { get; set; }

    public string MemberHobbie1 { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
