using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using ClamityMusic.MusicBoxes.ByJteoh;

namespace ClamityMusic.MusicBoxes
{
    public class ClamityTitleMusicBox : MusicBox
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.GetMod("Clamity") != null;
        }
        public override int MusicBoxTile => ModContent.TileType<ClamityTitleMusicBoxTile>();
        public override string MusicName => "Title";
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<ClamitasMusicBox>()
                //.AddIngredient<PyrogenMusicBox>()
                .AddIngredient<WoBMusicBox>()
                .AddIngredient<GiantClamMusicBox>()
                .AddIngredient<EarthElementalMusicBox>()
                .AddIngredient<CloudElementalMusicBox>()

                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
    public class ClamityTitleMusicBoxTile : MusicBoxTile
    {

    }
}
