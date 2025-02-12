using Terraria.ModLoader;

namespace ClamityMusic.MusicBoxes
{
    public class WoBMusicBox : MusicBox
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.HasMod("Clamity");
        }
        public override int MusicBoxTile => ModContent.TileType<WoBMusicBoxTile>();
        public override string MusicName => "WallOfBronze";
    }
    public class WoBMusicBoxTile : MusicBoxTile
    {

    }
}
