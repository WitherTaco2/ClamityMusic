using Terraria.ModLoader;

namespace ClamityMusic.MusicBoxes
{
    public class ClamitasMusicBox : MusicBox
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.HasMod("Clamity");
        }
        public override int MusicBoxTile => ModContent.TileType<ClamitasMusicBoxTile>();
        public override string MusicName => "Clamitas";
    }
    public class ClamitasMusicBoxTile : MusicBoxTile
    {

    }
}
