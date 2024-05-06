using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class GroupGenre
{
    public int GroupId { get; set; }

    public string GroupGenre1 { get; set; } = null!;

    public virtual Group Group { get; set; } = null!;
}
