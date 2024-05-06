---- twicedb ----

create database twicedb
go

use twicedb
go

---- Group ----
create table [Group](
  groupId int not null primary key identity(1, 1),
  groupName varchar(50) not null unique,
  groupKoreanName varchar(50),
  groupJapaneseName varchar(50),
  groupChineseName varchar(50),
  groupDescription varchar(255),
  groupOrigin varchar(50),
)
go

create table GroupAgency(
  groupId int not null references [Group](groupId),
  groupAgencyName varchar(50) not null,
  groupAgencyCountry varchar(50) not null
)
go

create table GroupDebut(
  groupId int not null references [Group](groupId),
  groupDebutCountry varchar(50) not null,
  groupDebutDate datetime not null
)
go

create table GroupGenre(
  groupId int not null references [Group](groupId),
  groupGenre varchar(50) not null
)
go

create table GroupSocial(
  groupId int not null references [Group](groupId),
  groupSocialName varchar(50) not null,
  groupSocialUrl varchar(255)
)
go

create table GroupGallery(
  groupId int not null references [Group](groupId),
  groupGalleryDescription varchar(50),
  groupGalleryImageUrl varchar(255) not null
)
go


create table GroupFanclub(
  groupFanclubId int not null primary key identity(1, 1),
  groupFanclubName varchar(50) not null unique,
  groupFanclubDescription varchar(255),
  groupId int not null references [Group](groupId),
)
go

create table GroupFanclubGallery(
  groupFanclubId int not null references GroupFanclub(groupFanclubId),
  groupFanclubGalleryDescription varchar(50),
  groupFanclubGalleryImageUrl varchar(50) not null
)
go

---- Discography ----
create table Discography(
  discographyId int not null primary key identity(1, 1),
  discographyName varchar(100) not null,
  discographyType varchar(50) not null,
  discographyImageUrl varchar(255),
  discographyCountry varchar(50),
  discographySpotifyUrl varchar(255),
  discographyYoutubeUrl varchar(255),
  discographyLaunchDate datetime default getdate(),
  groupId int not null references [Group](groupId)
)
go

create table DiscographyGallery(
  discographyId int not null references Discography(discographyId),
  discographyGalleryDescription varchar(50),
  discographyGalleryImageUrl varchar(255) not null
)
go

create table DiscographySong(
  discographyId int not null references Discography(discographyId),
  discographySongId int not null primary key identity(1, 1),
  discographySongName varchar(50) not null,
  discographySongGenre varchar(50),
  discographySongSpotifyUrl varchar(255),
  discographySongYoutubeUrl varchar(255)
)
go

create table DiscographySongCredits(
  discographySongId int not null references DiscographySong(discographySongId),
  discographySongCreditsName varchar(50) not null,
  discographySongCreditsType varchar(50) not null,
  discographySongCreditsProfileUrl varchar(255)
)
go

---- Member ----
create table Member(
  memberId int not null primary key identity(1, 1),
  memberName varchar(50) not null unique,
  memberNameRomaji varchar(50),
  memberNameEnglish varchar(50),
  memberNameComplete varchar(50) not null,
  memberAnimal varchar(50) not null,
  memberDateOfBirth datetime default getdate(),
  memberPlaceOfBirth varchar(50) not null,
  memberNacionality varchar(50),
  memberHeight float default 0.0,
  memberWeight int default 0,
  memberZodiacSign varchar(50),
  memberChineseZodiacSign varchar(50),
  memberBloodType varchar(50),
  groupId int not null references [Group](groupId),
)
go

create table MemberProfession(
  memberId int not null references Member(memberId),
  memberProfession varchar(50) not null
)
go

create table MemberSocial(
  memberId int not null references Member(memberId),
  memberSocialName varchar(50) not null,
  memberSocialUrl varchar(255) not null
)
go

create table MemberNickname(
  memberId int not null references Member(memberId),
  memberNickname varchar(50) not null
)
go

create table MemberLanguage(
  memberId int not null references Member(memberId),
  memberLanguage varchar(50) not null
)
go

create table MemberGallery(
  memberId int not null references Member(memberId),
  memberGalleryDescription varchar(50),
  memberGalleryImageUrl varchar(255) not null
)
go

create table MemberHobbie(
  memberId int not null references Member(memberId),
  memberHobbie varchar(50) not null
)
go

create table MemberFavoriteColor(
  memberId int not null references Member(memberId),
  memberFavoriteColor varchar(50) not null
)
go

create table MemberSkill(
  memberId int not null references Member(memberId),
  memberSkill varchar(50) not null
)
go

create table MemberPet(
  memberId int not null references Member(memberId),
  memberPetId int not null primary key identity(1, 1),
  memberPetName varchar(50) not null,
  memberPetBreed varchar(50) not null
)
go

create table MemberPetGallery(
  memberPetId int not null references MemberPet(memberPetId),
  memberPetGalleryDescription varchar(50),
  memberPetGalleryUrl varchar(255) not null
)
go