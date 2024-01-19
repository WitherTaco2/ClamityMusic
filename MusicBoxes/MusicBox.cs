using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ClamityMusic.MusicBoxes
{
    public abstract class MusicBox : ModItem, ILocalizedModType, IModType
    {
        public new string LocalizationCategory => "Items.Placeables.MusicBoxes";
        public abstract int MusicBoxTile { get; }
        public abstract string MusicName { get; }
        public virtual bool Obtainable { get; } = true;
        public override void SetStaticDefaults()
        {
            ItemID.Sets.CanGetPrefixes[Type] = false;
            ItemID.Sets.ShimmerTransformToItem[Type] = 576;
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/" + MusicName), this.Type, MusicBoxTile, 0);
            if (Obtainable)
                return;
            Item.ResearchUnlockCount = 0;
        }
        public override void SetDefaults() => Item.DefaultToMusicBox(this.MusicBoxTile, 0);
    }
    public abstract class MusicBoxTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleLineSkip = 2;
            TileObjectData.addTile(Type);
            TileID.Sets.DisableSmartCursor[Type] = true;
            this.AddMapEntry(new Color(191, 142, 111), Language.GetText("ItemName.MusicBox"));
        }

        public override void MouseOver(int i, int j)
        {
            Player localPlayer = Main.LocalPlayer;
            localPlayer.noThrow = 2;
            localPlayer.cursorItemIconEnabled = true;
            localPlayer.cursorItemIconID = TileLoader.GetItemDropFromTypeAndStyle(Type);
        }

        public override bool CreateDust(int i, int j, ref int type) => false;

        public override void DrawEffects(
          int i,
          int j,
          SpriteBatch spriteBatch,
          ref TileDrawInfo drawData)
        {
            if (Main.gamePaused || !Main.instance.IsActive || Lighting.UpdateEveryFrame && !Main.rand.NextBool(4))
                return;
            Tile tile = Main.tile[i, j];
            if (tile.TileFrameX != 36 || tile.TileFrameY % 36 != 0 || (int)Main.timeForVisualEffects % 7 != 0 || !Utils.NextBool(Main.rand, 3))
                return;
            int num = Main.rand.Next(570, 573);
            Vector2 vector2_1 = new((float)(i * 16 + 8), (float)(j * 16 - 8));
            Vector2 vector2_2 = new(Main.WindForVisuals * 2f, -0.5f);
            vector2_2.X *= 1f + Utils.NextFloat(Main.rand, -0.5f, 0.5f);
            vector2_2.Y *= 1f + Utils.NextFloat(Main.rand, -0.5f, 0.5f);
            if (num == 572)
                vector2_1.X -= 8f;
            if (num == 571)
                vector2_1.X -= 4f;
            Gore.NewGore(new EntitySource_TileUpdate(i, j), vector2_1, vector2_2, num, 0.8f);
        }
    }
}
