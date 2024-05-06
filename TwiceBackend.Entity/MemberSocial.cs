using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberSocial
{
    public int MemberId { get; set; }

    public string MemberSocialName { get; set; } = null!;

    public string MemberSocialUrl { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
