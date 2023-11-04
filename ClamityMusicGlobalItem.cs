using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria;

namespace ClamityMusic
{
    public class ClamityMusicGlobalItem : GlobalItem
    {
        public override bool? PrefixChance(Item item, int pre, UnifiedRandom rand) => (item.ModItem == null || item.ModItem.Mod != ClamityMusic.mod) ? new bool?() : new bool?(false);
    }
}
