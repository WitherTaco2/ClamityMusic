using CalamityMod.Items.TreasureBags.MiscGrabBags;
using ClamityMusic.MusicBoxes;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace ClamityMusic
{
    public class ClamityMusicGlobalItem : GlobalItem
    {
        public override bool? PrefixChance(Item item, int pre, UnifiedRandom rand) => (item.ModItem == null || item.ModItem.Mod != ClamityMusic.mod) ? new bool?() : new bool?(false);
        public override void ModifyItemLoot(Item item, ItemLoot itemLoot)
        {
            if (item.type == ModContent.ItemType<StarterBag>())
            {
                itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ClamityTitleMusicBox>()));
            }
        }
    }
}
