using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ClamityMusic.MusicBoxes
{
    public class CloudElementalMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<CloudElementalMusicBoxTile>();
        public override string MusicName => "CloudElemental";
    }
    public class CloudElementalMusicBoxTile : MusicBoxTile
    {

    }
}
