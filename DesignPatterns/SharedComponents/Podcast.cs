using System;
using System.Collections.Generic;

namespace SharedComponents
{
    public class Podcast
    {
        public Podcast(string name, string description, string rssFeedUrlString)
        {
            Name = name;
            Description = description;
            Episodes = new List<Episode>();
            RssFeedUrl = new Uri(rssFeedUrlString);
        }

        public Uri RssFeedUrl { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        private List<Episode> Episodes { get; set; }
    }
}