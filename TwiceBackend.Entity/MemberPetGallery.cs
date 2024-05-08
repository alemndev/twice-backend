using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberPetGallery
{
    public int MemberPetId { get; set; }

    public string? MemberPetGalleryDescription { get; set; }

    public string MemberPetGalleryUrl { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual MemberPet MemberPet { get; set; } = null!;
}
