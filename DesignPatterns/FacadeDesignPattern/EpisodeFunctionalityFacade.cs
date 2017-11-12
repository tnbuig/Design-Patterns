using SharedComponents;

namespace FacadeDesignPattern
{
    // The Facade - hiding complex sub system to simplify use.
    public class EpisodeFunctionalityFacade
    {
        private FileTransferClient fileTransferClient = new FileTransferClient();
        private MediaPlayer mediaPlayer = new MediaPlayer();
        private PubSubService pubsub = new PubSubService();

        public void PlayEpisode(Episode episode)
        {
            string filePath = "C:\\Users\\Oran\\Download\\" + episode.Title;

            if (!episode.Context.IsDownloaded)
            {
                bool downloadSucceded = fileTransferClient.DownloadFile(episode.DownloadUrl, filePath);
                if (!downloadSucceded) return;
            }

            mediaPlayer.PlayAudio(filePath);

            pubsub.PublishEvent<EpisodePlayingMessage>(new EpisodePlayingMessage(episode));
        }
    }
}