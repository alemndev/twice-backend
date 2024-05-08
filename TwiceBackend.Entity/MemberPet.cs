using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class MemberPet
{
    public int MemberId { get; set; }

    public int MemberPetId { get; set; }

    public string MemberPetName { get; set; } = null!;

    public string MemberPetBreed { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual Member Member { get; set; } = null!;
}
