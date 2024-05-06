using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class DiscographyGallery
{
    public int DiscographyId { get; set; }

    public string? DiscographyGalleryDescription { get; set; }

    public string DiscographyGalleryImageUrl { get; set; } = null!;

    public virtual Discography Discography { get; set; } = null!;
}
