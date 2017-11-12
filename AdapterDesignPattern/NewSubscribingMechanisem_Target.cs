using SharedComponents;
using System;

namespace AdapterDesignPattern
{
    public class NewSubscribingMechanisem_Target
    {
        public virtual void SubscribeToPodcast(Podcast podcast)
        {
            Console.WriteLine($"Subscribed to podcast: {podcast?.Name}");
        }

        public virtual void SubscribeToPodcast(Episode episode)
        {
            Console.WriteLine($"Subscribed to podcast: {episode?.Podcast?.Name}");
        }
    }
}