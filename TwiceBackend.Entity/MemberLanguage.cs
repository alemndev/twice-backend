using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberLanguage
{
    public int MemberId { get; set; }

    public string MemberLanguage1 { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
