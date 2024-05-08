using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class GroupAgency
{
    public int GroupId { get; set; }

    public string GroupAgencyName { get; set; } = null!;

    public string GroupAgencyCountry { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Group Group { get; set; } = null!;
}
