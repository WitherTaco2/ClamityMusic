using System;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.IO;

namespace ClamityMusic.MusicBoxes
{
    public class ClamitasMusicBox : MusicBox
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModLoader.GetMod("Clamity") != null;
        }
        public override int MusicBoxTile => ModContent.TileType<ClamitasMusicBoxTile>();
        public override string MusicName => "Clamitas";
    }
    public class ClamitasMusicBoxTile : MusicBoxTile
    {

    }
}
