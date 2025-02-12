using CalamityMod.Items.Materials;
using CalamityMod.Items.Placeables;
using Terraria.ID;
using Terraria.ModLoader;

namespace ClamityMusic.MusicBoxes
{
    public class AcidRainT2MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<AcidRainT2MusicBoxTile>();
        public override string MusicName => "AcidRain2";
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.MusicBox)
                .AddIngredient<Acidwood>(10)
                .AddIngredient<SulphuricScale>(10)
                .AddIngredient<CorrodedFossil>(10)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
    public class AcidRainT2MusicBoxTile : MusicBoxTile
    {

    }
}
