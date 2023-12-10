using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ClamityMusic.MusicBoxes
{
    public class ArmoredDiggerMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<AcidRainT2MusicBoxTile>();
        public override string MusicName => "ArmoredDigger";
    }
    public class ArmoredDiggerMusicBoxTile : MusicBoxTile
    {

    }
}
