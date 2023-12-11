using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ClamityMusic.MusicBoxes
{
    public class PlaguebringerMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<PlaguebringerMusicBoxTile>();
        public override string MusicName => "PlagueBringer";
    }
    public class PlaguebringerMusicBoxTile : MusicBoxTile
    {

    }
}
