using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PersistenceServiceBuilder builder;

            if (args[0] == "database")
            {
                builder = new DataBasePersistenceServiceBuilder();
                builder.InitializeService(@".\SQLEXPRESS;AttachDbFilename=C:\Podcast\App_Data\pocast.mdf;");
            }
            else
            {
                builder = new FileSystemPersistenceServiceBuilder();
                builder.InitializeService(@"C:\Users\Oran\Data");
            }

            builder.LoadValidatoinRules();
            builder.StartListen();

            PersistenceService persistenceService = builder.GetService();

            Console.WriteLine("Press <Enter> to continue");
            Console.ReadLine();
        }
    }
}
