
using CalamityMod.NPCs.SunkenSea;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace ClamityMusic
{
    public class ClamityMusicGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public int giantClamHits = 0;
        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            giantClamHits = 0;
        }
        public override void OnHitByItem(NPC npc, Player player, Item item, NPC.HitInfo hit, int damageDone)
        {
            if (npc.type == ModContent.NPCType<GiantClam>())
            {
                if (giantClamHits <= 5)
                    giantClamHits++;
            }
        }
        public override void OnHitByProjectile(NPC npc, Projectile projectile, NPC.HitInfo hit, int damageDone)
        {
            if (npc.type == ModContent.NPCType<GiantClam>())
            {
                if (giantClamHits <= 5)
                    giantClamHits++;
            }
        }
    }
}
