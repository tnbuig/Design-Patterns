using System;

namespace FacadeDesignPattern
{
    public class PubSubService
    {
        public void PublishEvent<T>(T message)
        {
            Console.WriteLine($"Message Arrived and published {message}");
        }
    }
}