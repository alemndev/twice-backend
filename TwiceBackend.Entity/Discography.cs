using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class Discography
{
    public int DiscographyId { get; set; }

    public string DiscographyName { get; set; } = null!;

    public string DiscographyType { get; set; } = null!;

    public string? DiscographyImageUrl { get; set; }

    public string? DiscographyCountry { get; set; }

    public string? DiscographySpotifyUrl { get; set; }

    public string? DiscographyYoutubeUrl { get; set; }

    public DateTime? DiscographyLaunchDate { get; set; }

    public int GroupId { get; set; }

    public virtual ICollection<DiscographySong> DiscographySongs { get; set; } = new List<DiscographySong>();

    public virtual Group Group { get; set; } = null!;
}
