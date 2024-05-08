using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberGallery
{
    public int MemberId { get; set; }

    public string? MemberGalleryDescription { get; set; }

    public string MemberGalleryImageUrl { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Member Member { get; set; } = null!;
}
