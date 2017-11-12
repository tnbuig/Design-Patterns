using SharedComponents;
using System;

namespace AdapterDesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating basic demo models
            Podcast radioLabPodcast = new Podcast("Radio Lab", "Radiolab is a show about curiosity. Where sound illuminates ideas, and the boundaries blur between science, philosophy, and human experience.", "http://feeds.wnyc.org/radiolab");
            Episode Episode123 = new Episode(radioLabPodcast, 123, "Oliver Sacks: A Journey From Where to Where", "There’s nothing quite like the sound of someone thinking out loud, struggling to find words and ideas to match what’s in their head. Today, we are allowed to dip into the unfiltered thoughts of Oliver Sacks, one of our heroes, in the last months of his life.");

            // Instantiate a new Adapter object which hide the legacy/incompatible "Adaptee" code
            var adapter = new SubscribingMechanisem_Adapter();
            var target = new NewSubscribingMechanisem_Target();

            // Using both objects with the same method signature.
            Console.WriteLine("\nSubscribing to Podcast using the Target Object: ");
            target.SubscribeToPodcast(radioLabPodcast);
            target.SubscribeToPodcast(Episode123);

            Console.WriteLine("\nSubscribing to Podcast using the Adapter Object: ");
            adapter.SubscribeToPodcast(radioLabPodcast);
            adapter.SubscribeToPodcast(Episode123);

            Console.WriteLine("Press <Enter> to continue...");
            Console.ReadLine();
        }
    }
}