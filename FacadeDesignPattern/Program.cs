using SharedComponents;
using System;

namespace FacadeDesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating basic demo models
            Podcast radioLabPodcast = new Podcast("Radio Lab", "Radiolab is a show about curiosity. Where sound illuminates ideas, and the boundaries blur between science, philosophy, and human experience.", "http://feeds.wnyc.org/radiolab");
            Episode episode = new Episode(radioLabPodcast, 123, "Oliver Sacks: A Journey From Where to Where", "There’s nothing quite like the sound of someone thinking out loud, struggling to find words and ideas to match what’s in their head. Today, we are allowed to dip into the unfiltered thoughts of Oliver Sacks, one of our heroes, in the last months of his life.");

            var facade = new EpisodeFunctionalityFacade();

            facade.PlayEpisode(episode);

            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
        }
    }
}