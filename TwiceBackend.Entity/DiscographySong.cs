using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class DiscographySong
{
    public int DiscographyId { get; set; }

    public int DiscographySongId { get; set; }

    public string DiscographySongName { get; set; } = null!;

    public string? DiscographySongGenre { get; set; }

    public string? DiscographySongSpotifyUrl { get; set; }

    public string? DiscographySongYoutubeUrl { get; set; }

    public virtual Discography Discography { get; set; } = null!;
}
