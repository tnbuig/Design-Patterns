namespace SharedComponents
{
    public interface IEpisodeContext
    {
        bool IsDownloaded { get; set; }
        bool IsFavourite { get; set; }
        bool IsPlayed { get; set; }

        void MarkedAsPlayed(bool isPlayed);
    }
}