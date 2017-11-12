using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FacadeDesignPattern
{
    public class MediaPlayer
    {
        public void PlayAudio(string path)
        {
            Console.WriteLine($"Play audio file in path = {path}");
        }
    }
}
