using System;
using System.Collections.Generic;
using System.IO;
using Steamworks;
using Steamworks.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamWorkshopDownloaderCSharp
{
    public class SteamWorkshop
    {
        public void DownloadItem(PublishedFileId id_of_workshop)
        {
            if (SteamFolderIsExisting())
            {
                SteamUGC.Download(id_of_workshop);
            }
            else
            {
                throw new Exception("Steam not Founded!!!");
            }
        }
        public bool SteamFolderIsExisting()
        {
            if(File.Exists(@"C:\Program Files (x86)\Steam"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
