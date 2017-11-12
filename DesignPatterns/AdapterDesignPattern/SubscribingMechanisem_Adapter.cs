using SharedComponents;
using System;

namespace AdapterDesignPattern
{
    public class SubscribingMechanisem_Adapter : NewSubscribingMechanisem_Target
    {
        private LegacySubscribingMechanisem_Adaptee adaptee = new LegacySubscribingMechanisem_Adaptee();

        public override void SubscribeToPodcast(Podcast podcast)
        {
            Console.WriteLine($"Subscribed to podcast: {podcast?.Name}");
            adaptee.Subscribe(podcast.RssFeedUrl);
        }

        public override void SubscribeToPodcast(Episode episode)
        {
            Console.WriteLine($"Subscribed to podcast: {episode?.Podcast?.Name}");
            adaptee.Subscribe(episode.Podcast.RssFeedUrl);
        }
    }
}