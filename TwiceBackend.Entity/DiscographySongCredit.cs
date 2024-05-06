using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class DiscographySongCredit
{
    public int DiscographySongId { get; set; }

    public string DiscographySongCreditsName { get; set; } = null!;

    public string DiscographySongCreditsType { get; set; } = null!;

    public string? DiscographySongCreditsProfileUrl { get; set; }

    public virtual DiscographySong DiscographySong { get; set; } = null!;
}
