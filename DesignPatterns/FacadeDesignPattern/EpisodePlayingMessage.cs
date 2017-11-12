using SharedComponents;

namespace FacadeDesignPattern
{
    public class EpisodePlayingMessage
    {
        public Episode Episode { get; }

        public EpisodePlayingMessage(Episode episode)
        {
            Episode = episode;
        }

        public override string ToString()
        {
            return $"Episode playing message with episode: {Episode.Title}";
        }
    }
}