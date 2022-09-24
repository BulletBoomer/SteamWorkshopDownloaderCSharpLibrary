using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steamworks;

namespace SteamWorkshopDownloaderCSharp
{
    public class SetAppIDOfSteamGame
    {
        public AppId SetAppID(AppId app, uint id_of_game)
        {
            app.Value = id_of_game;
            return app;
        }
    }
}
