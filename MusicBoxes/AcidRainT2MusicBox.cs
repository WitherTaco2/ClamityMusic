using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;
using CalamityMod.Items.Materials;
using CalamityMod.Items.Placeables;

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
