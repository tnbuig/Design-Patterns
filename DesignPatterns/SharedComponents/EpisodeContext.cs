using System;

namespace SharedComponents
{
    public class EpisodeContext : IEpisodeContext
    {
        public bool IsPlayed { get; set; }

        public bool IsFavourite { get; set; }

        public bool IsDownloaded { get; set; }

        public void MarkedAsPlayed(bool isPlayed)
        {
            IsPlayed = isPlayed;
            Console.WriteLine($"Marked Episode as played: {IsPlayed}");
        }

    }
}