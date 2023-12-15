using CalamityMod.NPCs.NormalNPCs;
using Terraria.ModLoader;
using Terraria;
using CalamityMod;
using CalamityMod.NPCs.PlagueEnemies;
using CalamityMod.World;
using CalamityMod.NPCs.ExoMechs.Ares;
using CalamityMod.NPCs.ExoMechs.Apollo;
using CalamityMod.NPCs.ExoMechs.Artemis;
using CalamityMod.NPCs.ExoMechs.Thanatos;
using CalamityMod.NPCs.ExoMechs;

namespace ClamityMusic.Scenes
{
    public class ExoMechdusaScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(ClamityMusic.mod, "Sounds/Music/ExoMechdusa");
        public override SceneEffectPriority Priority => (SceneEffectPriority)9;
        public override bool IsSceneEffectActive(Player player)
        {
            for (int i = 0; i < Main.npc.Length; i++)
            {
                NPC npc = Main.npc[i];
                if (npc == null) continue;
                if (!npc.active) continue;
                bool anyExoMech = npc.type == ModContent.NPCType<AresBody>()
                               || npc.type == ModContent.NPCType<Apollo>()
                               || npc.type == ModContent.NPCType<Artemis>()
                               || npc.type == ModContent.NPCType<ThanatosHead>();
                bool anyDraedon = npc.type == ModContent.NPCType<Draedon>();
                if (CalamityWorld.DraedonMechdusa && anyExoMech && player.SafeDirectionTo(npc.Center).Length() < 2000) return true;
            }
            return false;
        }
    }
}
