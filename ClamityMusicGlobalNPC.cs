
using CalamityMod.NPCs.SunkenSea;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace ClamityMusic
{
    public class ClamityMusicGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public int musicHitTrigger = 0;
        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            musicHitTrigger = 0;
        }
        public override void OnHitByItem(NPC npc, Player player, Item item, NPC.HitInfo hit, int damageDone)
        {
            /*if (npc.type == ModContent.NPCType<GiantClam>())
            {
                if (musicHitTrigger <= 5)
                    musicHitTrigger++;
            }*/
            UpdateMusicTrigger(npc, ModContent.NPCType<GiantClam>(), 5);
        }
        public override void OnHitByProjectile(NPC npc, Projectile projectile, NPC.HitInfo hit, int damageDone)
        {
            /*if (npc.type == ModContent.NPCType<GiantClam>())
            {
                if (musicHitTrigger <= 5)
                    musicHitTrigger++;
            }*/
            UpdateMusicTrigger(npc, ModContent.NPCType<GiantClam>(), 5);
        }
        private void UpdateMusicTrigger(NPC npc, int type, int maxHits)
        {
            if (npc.type == type)
            {
                if (musicHitTrigger <= maxHits)
                    musicHitTrigger++;
            }
        }
        /*public void CanTriggerMusic(NPC npc, int type, int maxHits)
        {

        }*/
    }
}
