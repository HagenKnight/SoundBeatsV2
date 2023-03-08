﻿namespace SoundBeats.Core.DTO
{
    public class AlbumDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string CoverUrl { get; set; }
        public string ImageType { get; set; }
        public int ArtistId { get; set; }
        public ArtistDTO Artist { get; set; }
    }
}
