using System;

namespace SharedComponents
{
    public class Episode
    {
        public Episode(Podcast podcast, int index, string title, string description)
        {
            Podcast = podcast;
            Index = index;
            Title = title;
            Description = description;
            Context = new EpisodeContext();
        }

        public int Index { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Podcast Podcast { get; set; }

        public EpisodeContext Context { get; set; }

        public Uri DownloadUrl { get; set; }
    }
}