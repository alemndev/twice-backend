using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class GroupDebut
{
    public int GroupId { get; set; }

    public string GroupDebutCountry { get; set; } = null!;

    public DateTime GroupDebutDate { get; set; }

    public virtual Group Group { get; set; } = null!;
}
