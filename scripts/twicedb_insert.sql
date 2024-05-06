---- Group ----

insert into [Group] (groupName, groupKoreanName, groupJapaneseName, groupChineseName, groupDescription, groupOrigin)
values (
  'TWICE',
  'Teuwaiseu',
  'Towaisu',
  'Wèi sī jì',
  'TWICE te conquistará "Dos veces": una vez por los ojos y otra por los oídos. O lo que sería lo mismo, la primera por sus increíbles puestas en escena y la segunda vez con su excepcional música.',
  'korea'
)
go

insert into GroupAgency (groupId, groupAgencyName, groupAgencyCountry)
values (1, 'JYP Entertainment', 'Corea del sur')
go

insert into GroupAgency (groupId, groupAgencyName, groupAgencyCountry)
values (1, 'Warner Music Japan', 'Japón')
go

insert into GroupDebut (groupId, groupDebutCountry, groupDebutDate)
values (1, 'korea', '2015-10-20')
go

insert into GroupDebut (groupId, groupDebutCountry, groupDebutDate)
values (1, 'japan', '2017-6-28')
go

insert into GroupDebut (groupId, groupDebutCountry, groupDebutDate)
values (1, 'global', '2021-10-01')
go

insert into GroupGenre (groupId, groupGenre)
values (1, 'K-Pop')
go

insert into GroupGenre (groupId, groupGenre)
values (1, 'J-Pop')
go

insert into GroupSocial (groupId, groupSocialName, groupSocialUrl)
values (1, 'TWICE JAPAN - Webpage', 'https://www.twicejapan.com/')
go

insert into GroupSocial (groupId, groupSocialName, groupSocialUrl)
values (1, 'TWICE JYP - Webpage', 'https://twice.jype.com/')
go

insert into GroupSocial (groupId, groupSocialName, groupSocialUrl)
values (1, 'TWICE Shop - Webpage', 'https://twiceshop.com/')
go

insert into GroupSocial (groupId, groupSocialName, groupSocialUrl)
values (1, '@twicetagram - Instagram', 'https://www.instagram.com/twicetagram/')
go

insert into GroupSocial (groupId, groupSocialName, groupSocialUrl)
values (1, 'JYPETWICE - Facebook', 'https://www.facebook.com/JYPETWICE')
go

insert into GroupGallery (groupId, groupGalleryDescription, groupGalleryImageUrl)
values (1, 'I GOT YOU banner', 'https://lh3.googleusercontent.com/4e5MMLyxqRuj5FmoRskQ5tdwiipFohQxgK0tAQt07E0WZkejDlqc87--sH1FXGX8IfZfNah2V7AfdPo=w2880-h1200-p-l90-rj')
go

insert into GroupFanclub (groupFanclubName, groupFanclubDescription, groupId)
values ('ONCE', 'Una vez y dos veces, ambas palabras van juntas como el hilo y la aguja. Incluso si los fans sólo las aman una vez, ellas les darán el doble de amor. ¡Una vez un fan, Dos veces la diversión!', 1)
go

---- Discography ----

insert into Discography (discographyName, discographyType, discographyImageUrl, discographyCountry, discographySpotifyUrl, discographyYoutubeUrl, discographyLaunchDate, groupId)
values (
  'Twicetagram',
  'album',
  'https://static.wikia.nocookie.net/drama/images/6/6c/TWICE_-_Twicetagram.jpeg/revision/latest?cb=20171029150648&path-prefix=es',
  'korea',
  'https://open.spotify.com/album/3hJXmK5gWN9P6jtZL0Lr2y?si=4nvtapthT0C5jNbBdDx9lQ',
  'https://www.youtube.com/playlist?list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA',
  '2017-10-30',
  1
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Likey',
  'https://open.spotify.com/track/0IEVKWduAaMcZepZQVr80T?si=0f0fcbafe43343f0',
  'https://www.youtube.com/watch?v=V2hlQkVJZhE&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=1'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Turtle',
  'https://open.spotify.com/track/1LQtxz9fIrZskoqDSbhKd3?si=56319428a8b547fd',
  'https://www.youtube.com/watch?v=tVv_C2fYStU&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=2&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Missing U',
  'https://open.spotify.com/track/533SwLFNhqFUo4Ae6sByFe?si=81de99fee33f4e82',
  'https://www.youtube.com/watch?v=U9cP8pjmtSs&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=3&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Wow',
  'https://open.spotify.com/track/3Noc2UKlozJU0jwOA4RAw6?si=b1a5b463bfcb4b06',
  'https://www.youtube.com/watch?v=ngpGqFCioUI&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=4&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Ffw',
  'https://open.spotify.com/track/0gDIPvuhlWvnO7DGJZO0VC?si=901042615a8b4075',
  'https://www.youtube.com/watch?v=NGrmg1vBYCU&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=5&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Ding Dong',
  'https://open.spotify.com/track/63jzQKpH2DkYVCX0phXh79?si=d3981e809047499c',
  'https://www.youtube.com/watch?v=MKapiFDDaGA&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=6&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  '24/7',
  'https://open.spotify.com/track/3uGY1Q4IVrwbXya0d1OTUH?si=231f694602844795',
  'https://www.youtube.com/watch?v=2Z1C9rJtUHA&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=7&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Look at Me',
  'https://open.spotify.com/track/6Jkcg39vqttJezD7nfqrSj?si=fefd7f5a47e6401a',
  'https://www.youtube.com/watch?v=Q97pvL6GsIA&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=8&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Rollin',
  'https://open.spotify.com/track/0w1vWDzGSlG0b0yNmlDhIm?si=7ea5fef473664de8',
  'https://www.youtube.com/watch?v=jpvWkizFIEM&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=9&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Love Line',
  'https://open.spotify.com/track/4xjN8AE7XyoBuh4ts1tY1V?si=ef70d4e424344460',
  'https://www.youtube.com/watch?v=-Q2aX-BBjK8&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=10&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Dont Give Up',
  'https://open.spotify.com/track/2mC6CxG3KQ0EXb7g67zPTA?si=f10c19b7981948e6',
  'https://www.youtube.com/watch?v=97PCZFThkVM&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=11&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'You in My Heart',
  'https://open.spotify.com/track/6gqHFc6BAAUkLdHTr7vlXZ?si=ce03ac4d5096422b',
  'https://www.youtube.com/watch?v=hoPOCZJv_2M&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=12&pp=8AUB'
)
go

insert into DiscographySong (discographyId, discographySongName, discographySongSpotifyUrl, discographySongYoutubeUrl)
values (
  1,
  'Jaljayo Good Night',
  'https://open.spotify.com/track/1OFJ8o35oCIcaWjYq0bHOS?si=dd3488071293446e',
  'https://www.youtube.com/watch?v=WMs-SzOSfzs&list=OLAK5uy_mbnZR5lZg8nzTKJQ-AufvwFwsT97pewZA&index=13&pp=8AUB'
)
go