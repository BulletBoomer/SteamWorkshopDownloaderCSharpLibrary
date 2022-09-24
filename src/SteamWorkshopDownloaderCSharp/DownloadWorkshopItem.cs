using Steamworks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamWorkshopDownloaderCSharp
{
    public class DownloadWorkshopItem
    {
        public void DownloadWorkshopItem_GameRust(uint rust_workshopID)
        {
            SteamWorkshop st = new SteamWorkshop();
            st.DownloadItem((PublishedFileId)rust_workshopID);
        }
    }
}
