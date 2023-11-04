using CalamityMod.Buffs.StatDebuffs;
using Terraria.ModLoader;

namespace ClamityMusic
{
	public class ClamityMusic : Mod
    {
        public static ClamityMusic mod;
        public static Mod clamity;
        public override void Load()
        {
            mod = this;
            ModLoader.TryGetMod("Clamity", out clamity);
        }
        public override void Unload()
        {
            mod = null;
            clamity = null;
        }
    }
}