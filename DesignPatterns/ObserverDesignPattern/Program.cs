using SharedComponents;
using System;
using System.Collections.Generic;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating basic demo models
            Podcast radioLabPodcast = new Podcast("Radio Lab", "Radiolab is a show about curiosity. Where sound illuminates ideas, and the boundaries blur between science, philosophy, and human experience.", "http://feeds.wnyc.org/radiolab");
            Episode Episode123 = new Episode(radioLabPodcast, 123, "Oliver Sacks1: A Journey From Where to Where", "There’s nothing quite like the sound of someone thinking.");
            Episode Episode215 = new Episode(radioLabPodcast, 215, "Oliver Sacks2: A Journey From here to there", "1000 steps start with...");

            var podcastController = new PodcastController(radioLabPodcast);
            podcastController.Attach(Episode123.Context);
            podcastController.Attach(Episode215.Context);

            podcastController.MarkedAllAsPlayed();
            Console.WriteLine("Call Podcast Controller to mark all episode as played\n");

            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
        }
    }

    public class PodcastController
    {
        Podcast podcast;
        List<IEpisodeContext> episodeContexts;

        public PodcastController(Podcast podcast)
        {
            this.podcast = podcast;
            episodeContexts = new List<IEpisodeContext>();
        }
        
        public void Attach(IEpisodeContext context)
        {
            episodeContexts.Add(context);
        }
         
        public void Detach(IEpisodeContext context)
        {
            episodeContexts.Remove(context);
        }

        public void MarkedAllAsPlayed()
        {
            foreach (IEpisodeContext context in episodeContexts)
            {
                context.MarkedAsPlayed(true);
            }
        }
        
        public void MarkedAllAsNotplayed()
        {
            foreach (IEpisodeContext context in episodeContexts)
            {
                context.MarkedAsPlayed(false);
            }
        }

    }

}
