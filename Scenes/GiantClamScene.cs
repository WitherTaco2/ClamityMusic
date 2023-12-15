using CalamityMod;
using Terraria;
using Terraria.ModLoader;

namespace ClamityMusic.Scenes
{
    public class GiantClamScene : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(ClamityMusic.mod, "Sounds/Music/GiantClam");
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override bool IsSceneEffectActive(Player player)
        {
            for (int i = 0; i < Main.npc.Length; i++)
            {
                NPC npc = Main.npc[i];
                if (npc == null) continue;
                if (!npc.active) continue;
                if (npc.GetGlobalNPC<ClamityMusicGlobalNPC>().giantClamHits >= 5 && player.SafeDirectionTo(npc.Center).Length() < 2000) return true;
            }
            return false;
        }
    }
}
