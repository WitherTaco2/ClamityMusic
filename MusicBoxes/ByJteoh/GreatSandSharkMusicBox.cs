using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ClamityMusic.MusicBoxes.ByJteoh
{
    public class GreatSandSharkMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<GreatSandSharkMusicBoxTile>();
        public override string MusicName => "GreatSandShark";
    }
    public class GreatSandSharkMusicBoxTile : MusicBoxTile
    {

    }
}
