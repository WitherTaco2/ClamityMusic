using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ClamityMusic.MusicBoxes
{
    public class GiantClamMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<GiantClamMusicBoxTile>();
        public override string MusicName => "GiantClam";
    }
    public class GiantClamMusicBoxTile : MusicBoxTile
    {

    }
}
