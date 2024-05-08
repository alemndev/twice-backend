using System;
using System.Collections.Generic;

namespace TwiceBackend.Entity;

public partial class Member
{
    public int MemberId { get; set; }

    public string MemberName { get; set; } = null!;

    public string? MemberNameRomaji { get; set; }

    public string? MemberNameEnglish { get; set; }

    public string MemberNameComplete { get; set; } = null!;

    public string MemberAnimal { get; set; } = null!;

    public DateTime? MemberDateOfBirth { get; set; }

    public string MemberPlaceOfBirth { get; set; } = null!;

    public string? MemberNacionality { get; set; }

    public double? MemberHeight { get; set; }

    public int? MemberWeight { get; set; }

    public string? MemberZodiacSign { get; set; }

    public string? MemberChineseZodiacSign { get; set; }

    public string? MemberBloodType { get; set; }

    public int GroupId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual ICollection<MemberPet> MemberPets { get; set; } = new List<MemberPet>();
}
