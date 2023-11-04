using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ClamityMusic.MusicBoxes
{
    public class EarthElementalMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<EarthElementalMusicBoxTile>();
        public override string MusicName => "EarthElemental";
    }
    public class EarthElementalMusicBoxTile : MusicBoxTile
    {

    }
}
