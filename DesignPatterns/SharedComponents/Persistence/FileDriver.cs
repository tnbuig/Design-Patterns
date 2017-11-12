namespace SharedComponents
{
    public class FileDriver : IPersistenceDriver
    {
        private string path;

        public FileDriver(string path)
        {
            this.path = path;
        }
    }
}