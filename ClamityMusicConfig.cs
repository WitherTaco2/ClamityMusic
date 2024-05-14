using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ClamityMusic
{
    public enum PyroMusic : int
    {
        CryogenPlaceholder,
        AstroGels,
        BrimstonePremiums
    }
    public class ClamityMusicConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public static ClamityMusicConfig Instance;

        //[Label("$Mods.TooltipIcon.TooltipIconConfig.Label.ItemIDTooltip")]
        [DefaultValue(PyroMusic.CryogenPlaceholder)]
        public PyroMusic PyrogenPrototypeTheme;

        [DefaultValue(true)]
        public bool UsesT2AcidRainTheme;
    }
}
