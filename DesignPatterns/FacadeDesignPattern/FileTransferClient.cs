using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    public class FileTransferClient
    {
        public bool DownloadFile(Uri fileUrl, string targetPath)
        {
            Console.WriteLine($"\nDownloading file from the {fileUrl} to {targetPath}.");
            return true;
        }
    }
}
