using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class GroupFanclubGallery
{
    public int GroupFanclubId { get; set; }

    public string? GroupFanclubGalleryDescription { get; set; }

    public string GroupFanclubGalleryImageUrl { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual GroupFanclub GroupFanclub { get; set; } = null!;
}
