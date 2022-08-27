﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class LargeStalactites : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return false;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 18;

            if (frame < 3)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargeIcicle>();
            else if (frame < 6)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargeStoneStalactite>();
            else if (frame < 9)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.WebHangingVictim>();
            else if (frame < 12)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargePearlstoneStalactite>();
            else if (frame < 15)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargeEbonstoneStalactite>();
            else if (frame < 18)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargeCrimstoneStalactite>();
            else if (frame < 21)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargeSandstoneStalactite>();
            else if (frame < 24)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargeGraniteStalactite>();
            else if (frame < 27)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargeMarbleStalactite>();
            else if (frame < 30)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargePinkIcicle>();
            else if (frame < 33)
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargePurpleIcicle>();
            else
                item = ModContent.ItemType<Items.Natural.Ambient.LargeStalactites.LargeRedIcicle>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 16, 32, item);
        }
    }
}