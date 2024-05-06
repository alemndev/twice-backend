using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberFavoriteColor
{
    public int MemberId { get; set; }

    public string MemberFavoriteColor1 { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
