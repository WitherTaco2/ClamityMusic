using Terraria.ModLoader;

namespace ClamityMusic.MusicBoxes
{
    public class ClamityTitleMusicBox : MusicBox
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.HasMod("Clamity");
        }
        public override int MusicBoxTile => ModContent.TileType<ClamityTitleMusicBoxTile>();
        public override string MusicName => "Title";
        /*public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ClamitasMusicBox>()
                //.AddIngredient<PyrogenMusicBox>()
                .AddIngredient<WoBMusicBox>()
                .AddIngredient<FrozenHellMusicBox>()

                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }*/
    }
    public class ClamityTitleMusicBoxTile : MusicBoxTile
    {

    }
}
