using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
