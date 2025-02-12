using Terraria.ModLoader;

namespace ClamityMusic.MusicBoxes
{
    public class PyrogenGFBMusicBox : MusicBox
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.HasMod("Clamity");
        }
        public override int MusicBoxTile => ModContent.TileType<PyrogenGFBMusicBoxTile>();
        public override string MusicName => "PyrogenGFB";
    }
    public class PyrogenGFBMusicBoxTile : MusicBoxTile
    {
    }
}
