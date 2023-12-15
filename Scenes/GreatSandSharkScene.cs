using Terraria.ModLoader;
using Terraria;
using CalamityMod;
using CalamityMod.NPCs.GreatSandShark;

namespace ClamityMusic.Scenes
{
    public class GreatSandSharkScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(ClamityMusic.mod, "Sounds/Music/GreatSandShark");
        public override SceneEffectPriority Priority => SceneEffectPriority.Event;
        public override bool IsSceneEffectActive(Player player)
        {
            for (int i = 0; i < Main.npc.Length; i++)
            {
                NPC npc = Main.npc[i];
                if (npc == null) continue;
                if (!npc.active) continue;
                if (npc.type == ModContent.NPCType<GreatSandShark>() && player.SafeDirectionTo(npc.Center).Length() < 2000) return true;
            }
            return false;
        }
    }
}
