using AdapterDesignPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedComponents;

namespace AdapterDesignPatternTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Podcast radioLabPodcast = new Podcast("Radio Lab", "Radiolab is a show about curiosity. Where sound illuminates ideas, and the boundaries blur between science, philosophy, and human experience.", "http://feeds.wnyc.org/radiolab");
            Episode Episode123 = new Episode(radioLabPodcast, 123, "Oliver Sacks: A Journey From Where to Where", "There’s nothing quite like the sound of someone thinking out loud, struggling to find words and ideas to match what’s in their head. Today, we are allowed to dip into the unfiltered thoughts of Oliver Sacks, one of our heroes, in the last months of his life.");

            var adapter = new SubscribingMechanisem_Adapter();
            var target = new NewSubscribingMechanisem_Target();

            target.SubscribeToPodcast(radioLabPodcast);
            target.SubscribeToPodcast(Episode123)

        }
    }
}
