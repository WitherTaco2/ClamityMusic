﻿using CalamityMod;
using CalamityMod.Events;
using Terraria;
using Terraria.ModLoader;

namespace ClamityMusic.Scenes
{
    public class AcidRain2SceneMusic : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(ClamityMusic.mod, "Sounds/Music/AcidRain2");
        public override SceneEffectPriority Priority => SceneEffectPriority.Event;
        public override bool IsSceneEffectActive(Player player)
        {
            return AcidRainEvent.HasStartedAcidicDownpour && player.Calamity().ZoneSulphur && Main.hardMode && DownedBossSystem.downedAquaticScourge && !DownedBossSystem.downedPolterghast;
        }
    }
}
