using Terraria.ModLoader;

namespace ClamityMusic.MusicBoxes
{
    public class FrozenHellMusicBox : MusicBox
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.HasMod("Clamity");
        }
        public override int MusicBoxTile => ModContent.TileType<FrozenHellMusicBoxTile>();
        public override string MusicName => "FrozenHell";
    }
    public class FrozenHellMusicBoxTile : MusicBoxTile
    {
    }
}
