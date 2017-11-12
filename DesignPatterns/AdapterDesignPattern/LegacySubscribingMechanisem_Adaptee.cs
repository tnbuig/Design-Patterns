using System;

namespace AdapterDesignPattern
{
    public class LegacySubscribingMechanisem_Adaptee
    {
        public void Subscribe(Uri podcastUri)
        {
            Console.WriteLine($"Subscribed to podcast with uri: {podcastUri}");
        }
    }
}