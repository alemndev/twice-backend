using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using TwiceBackend.Entity;

namespace TwiceBackend.DAL.DBContext;

public partial class TwicedbContext : DbContext
{
    public TwicedbContext()
    {
    }

    public TwicedbContext(DbContextOptions<TwicedbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Discography> Discographies { get; set; }

    public virtual DbSet<DiscographyGallery> DiscographyGalleries { get; set; }

    public virtual DbSet<DiscographySong> DiscographySongs { get; set; }

    public virtual DbSet<DiscographySongCredit> DiscographySongCredits { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupAgency> GroupAgencies { get; set; }

    public virtual DbSet<GroupDebut> GroupDebuts { get; set; }

    public virtual DbSet<GroupFanclub> GroupFanclubs { get; set; }

    public virtual DbSet<GroupFanclubGallery> GroupFanclubGalleries { get; set; }

    public virtual DbSet<GroupGallery> GroupGalleries { get; set; }

    public virtual DbSet<GroupGenre> GroupGenres { get; set; }

    public virtual DbSet<GroupSocial> GroupSocials { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberFavoriteColor> MemberFavoriteColors { get; set; }

    public virtual DbSet<MemberGallery> MemberGalleries { get; set; }

    public virtual DbSet<MemberHobbie> MemberHobbies { get; set; }

    public virtual DbSet<MemberLanguage> MemberLanguages { get; set; }

    public virtual DbSet<MemberNickname> MemberNicknames { get; set; }

    public virtual DbSet<MemberPet> MemberPets { get; set; }

    public virtual DbSet<MemberPetGallery> MemberPetGalleries { get; set; }

    public virtual DbSet<MemberProfession> MemberProfessions { get; set; }

    public virtual DbSet<MemberSkill> MemberSkills { get; set; }

    public virtual DbSet<MemberSocial> MemberSocials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Discography>(entity =>
        {
            entity.HasKey(e => e.DiscographyId).HasName("PK__Discogra__ED24001C0BFF1448");

            entity.ToTable("Discography");

            entity.Property(e => e.DiscographyId).HasColumnName("discographyId");
            entity.Property(e => e.DiscographyCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("discographyCountry");
            entity.Property(e => e.DiscographyImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("discographyImageUrl");
            entity.Property(e => e.DiscographyLaunchDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("discographyLaunchDate");
            entity.Property(e => e.DiscographyName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("discographyName");
            entity.Property(e => e.DiscographySpotifyUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("discographySpotifyUrl");
            entity.Property(e => e.DiscographyType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("discographyType");
            entity.Property(e => e.DiscographyYoutubeUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("discographyYoutubeUrl");
            entity.Property(e => e.GroupId).HasColumnName("groupId");

            entity.HasOne(d => d.Group).WithMany(p => p.Discographies)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Discograp__group__4AB81AF0");
        });

        modelBuilder.Entity<DiscographyGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DiscographyGallery");

            entity.Property(e => e.DiscographyGalleryDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("discographyGalleryDescription");
            entity.Property(e => e.DiscographyGalleryImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("discographyGalleryImageUrl");
            entity.Property(e => e.DiscographyId).HasColumnName("discographyId");

            entity.HasOne(d => d.Discography).WithMany()
                .HasForeignKey(d => d.DiscographyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Discograp__disco__4CA06362");
        });

        modelBuilder.Entity<DiscographySong>(entity =>
        {
            entity.HasKey(e => e.DiscographySongId).HasName("PK__Discogra__C4967603D7F697B3");

            entity.ToTable("DiscographySong");

            entity.Property(e => e.DiscographySongId).HasColumnName("discographySongId");
            entity.Property(e => e.DiscographyId).HasColumnName("discographyId");
            entity.Property(e => e.DiscographySongGenre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("discographySongGenre");
            entity.Property(e => e.DiscographySongName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("discographySongName");
            entity.Property(e => e.DiscographySongSpotifyUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("discographySongSpotifyUrl");
            entity.Property(e => e.DiscographySongYoutubeUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("discographySongYoutubeUrl");

            entity.HasOne(d => d.Discography).WithMany(p => p.DiscographySongs)
                .HasForeignKey(d => d.DiscographyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Discograp__disco__4F7CD00D");
        });

        modelBuilder.Entity<DiscographySongCredit>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DiscographySongCreditsName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("discographySongCreditsName");
            entity.Property(e => e.DiscographySongCreditsProfileUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("discographySongCreditsProfileUrl");
            entity.Property(e => e.DiscographySongCreditsType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("discographySongCreditsType");
            entity.Property(e => e.DiscographySongId).HasColumnName("discographySongId");

            entity.HasOne(d => d.DiscographySong).WithMany()
                .HasForeignKey(d => d.DiscographySongId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Discograp__disco__5165187F");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Group__88C1034DD3C8196B");

            entity.ToTable("Group");

            entity.HasIndex(e => e.GroupName, "UQ__Group__9011AC82F4688F86").IsUnique();

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.GroupChineseName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupChineseName");
            entity.Property(e => e.GroupDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("groupDescription");
            entity.Property(e => e.GroupJapaneseName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupJapaneseName");
            entity.Property(e => e.GroupKoreanName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupKoreanName");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupName");
            entity.Property(e => e.GroupOrigin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupOrigin");
        });

        modelBuilder.Entity<GroupAgency>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupAgency");

            entity.Property(e => e.GroupAgencyCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupAgencyCountry");
            entity.Property(e => e.GroupAgencyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupAgencyName");
            entity.Property(e => e.GroupId).HasColumnName("groupId");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupAgen__group__398D8EEE");
        });

        modelBuilder.Entity<GroupDebut>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupDebut");

            entity.Property(e => e.GroupDebutCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupDebutCountry");
            entity.Property(e => e.GroupDebutDate)
                .HasColumnType("datetime")
                .HasColumnName("groupDebutDate");
            entity.Property(e => e.GroupId).HasColumnName("groupId");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupDebu__group__3B75D760");
        });

        modelBuilder.Entity<GroupFanclub>(entity =>
        {
            entity.HasKey(e => e.GroupFanclubId).HasName("PK__GroupFan__330725D769C5DA7E");

            entity.ToTable("GroupFanclub");

            entity.HasIndex(e => e.GroupFanclubName, "UQ__GroupFan__8F0FE6CE6B4EE463").IsUnique();

            entity.Property(e => e.GroupFanclubId).HasColumnName("groupFanclubId");
            entity.Property(e => e.GroupFanclubDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("groupFanclubDescription");
            entity.Property(e => e.GroupFanclubName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupFanclubName");
            entity.Property(e => e.GroupId).HasColumnName("groupId");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupFanclubs)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupFanc__group__44FF419A");
        });

        modelBuilder.Entity<GroupFanclubGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupFanclubGallery");

            entity.Property(e => e.GroupFanclubGalleryDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupFanclubGalleryDescription");
            entity.Property(e => e.GroupFanclubGalleryImageUrl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupFanclubGalleryImageUrl");
            entity.Property(e => e.GroupFanclubId).HasColumnName("groupFanclubId");

            entity.HasOne(d => d.GroupFanclub).WithMany()
                .HasForeignKey(d => d.GroupFanclubId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupFanc__group__46E78A0C");
        });

        modelBuilder.Entity<GroupGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupGallery");

            entity.Property(e => e.GroupGalleryDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupGalleryDescription");
            entity.Property(e => e.GroupGalleryImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("groupGalleryImageUrl");
            entity.Property(e => e.GroupId).HasColumnName("groupId");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupGall__group__412EB0B6");
        });

        modelBuilder.Entity<GroupGenre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupGenre");

            entity.Property(e => e.GroupGenre1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupGenre");
            entity.Property(e => e.GroupId).HasColumnName("groupId");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupGenr__group__3D5E1FD2");
        });

        modelBuilder.Entity<GroupSocial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GroupSocial");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.GroupSocialName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("groupSocialName");
            entity.Property(e => e.GroupSocialUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("groupSocialUrl");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GroupSoci__group__3F466844");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Member__7FD7CF16F124578B");

            entity.ToTable("Member");

            entity.HasIndex(e => e.MemberName, "UQ__Member__67758EAF037BFD46").IsUnique();

            entity.Property(e => e.MemberId).HasColumnName("memberId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.MemberAnimal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberAnimal");
            entity.Property(e => e.MemberBloodType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberBloodType");
            entity.Property(e => e.MemberChineseZodiacSign)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberChineseZodiacSign");
            entity.Property(e => e.MemberDateOfBirth)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("memberDateOfBirth");
            entity.Property(e => e.MemberHeight)
                .HasDefaultValue(0.0)
                .HasColumnName("memberHeight");
            entity.Property(e => e.MemberNacionality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberNacionality");
            entity.Property(e => e.MemberName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberName");
            entity.Property(e => e.MemberNameComplete)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberNameComplete");
            entity.Property(e => e.MemberNameEnglish)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberNameEnglish");
            entity.Property(e => e.MemberNameRomaji)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberNameRomaji");
            entity.Property(e => e.MemberPlaceOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberPlaceOfBirth");
            entity.Property(e => e.MemberWeight)
                .HasDefaultValue(0)
                .HasColumnName("memberWeight");
            entity.Property(e => e.MemberZodiacSign)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberZodiacSign");

            entity.HasOne(d => d.Group).WithMany(p => p.Members)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Member__groupId__5812160E");
        });

        modelBuilder.Entity<MemberFavoriteColor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberFavoriteColor");

            entity.Property(e => e.MemberFavoriteColor1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberFavoriteColor");
            entity.Property(e => e.MemberId).HasColumnName("memberId");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberFav__membe__656C112C");
        });

        modelBuilder.Entity<MemberGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberGallery");

            entity.Property(e => e.MemberGalleryDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberGalleryDescription");
            entity.Property(e => e.MemberGalleryImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("memberGalleryImageUrl");
            entity.Property(e => e.MemberId).HasColumnName("memberId");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberGal__membe__619B8048");
        });

        modelBuilder.Entity<MemberHobbie>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberHobbie");

            entity.Property(e => e.MemberHobbie1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberHobbie");
            entity.Property(e => e.MemberId).HasColumnName("memberId");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberHob__membe__6383C8BA");
        });

        modelBuilder.Entity<MemberLanguage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberLanguage");

            entity.Property(e => e.MemberId).HasColumnName("memberId");
            entity.Property(e => e.MemberLanguage1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberLanguage");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberLan__membe__5FB337D6");
        });

        modelBuilder.Entity<MemberNickname>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberNickname");

            entity.Property(e => e.MemberId).HasColumnName("memberId");
            entity.Property(e => e.MemberNickname1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberNickname");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberNic__membe__5DCAEF64");
        });

        modelBuilder.Entity<MemberPet>(entity =>
        {
            entity.HasKey(e => e.MemberPetId).HasName("PK__MemberPe__1C345E4692462E52");

            entity.ToTable("MemberPet");

            entity.Property(e => e.MemberPetId).HasColumnName("memberPetId");
            entity.Property(e => e.MemberId).HasColumnName("memberId");
            entity.Property(e => e.MemberPetBreed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberPetBreed");
            entity.Property(e => e.MemberPetName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberPetName");

            entity.HasOne(d => d.Member).WithMany(p => p.MemberPets)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberPet__membe__6A30C649");
        });

        modelBuilder.Entity<MemberPetGallery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberPetGallery");

            entity.Property(e => e.MemberPetGalleryDescription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberPetGalleryDescription");
            entity.Property(e => e.MemberPetGalleryUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("memberPetGalleryUrl");
            entity.Property(e => e.MemberPetId).HasColumnName("memberPetId");

            entity.HasOne(d => d.MemberPet).WithMany()
                .HasForeignKey(d => d.MemberPetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberPet__membe__6C190EBB");
        });

        modelBuilder.Entity<MemberProfession>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberProfession");

            entity.Property(e => e.MemberId).HasColumnName("memberId");
            entity.Property(e => e.MemberProfession1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberProfession");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberPro__membe__59FA5E80");
        });

        modelBuilder.Entity<MemberSkill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberSkill");

            entity.Property(e => e.MemberId).HasColumnName("memberId");
            entity.Property(e => e.MemberSkill1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberSkill");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberSki__membe__6754599E");
        });

        modelBuilder.Entity<MemberSocial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MemberSocial");

            entity.Property(e => e.MemberId).HasColumnName("memberId");
            entity.Property(e => e.MemberSocialName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("memberSocialName");
            entity.Property(e => e.MemberSocialUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("memberSocialUrl");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MemberSoc__membe__5BE2A6F2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
