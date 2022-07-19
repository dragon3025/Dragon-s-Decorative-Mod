﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.Enums;

namespace DragonsDecorativeMod.Tiles.Natural
{
    public class AmbientObjectsC : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileLighted[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 54;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 54;

            if (frame <= 2)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.LihzahrdRubble>();
            if (frame <= 4)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.UndergroundCage>();
            if (frame <= 5)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.RustyMinecart>();
            if (frame <= 7)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.Well>();
            if (frame <= 8)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.ShovelAndDirt>();
            if (frame <= 9)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.Tent>();
            if (frame <= 10)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.WheelbarrowOfDirt>();
            if (frame <= 11)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.WoodPoleWithRope>();
            if (frame <= 17)
                item = ModContent.ItemType<Items.Natural.Ambient.Tile187.SandstonePiles>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 54, 32, item);
        }
    }
}