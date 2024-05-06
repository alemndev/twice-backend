using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class GroupGallery
{
    public int GroupId { get; set; }

    public string? GroupGalleryDescription { get; set; }

    public string GroupGalleryImageUrl { get; set; } = null!;

    public virtual Group Group { get; set; } = null!;
}
