﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DragonsDecorativeMod.Tiles.Botanic
{
    public class HangingPlant : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[3] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(101, 110, 86));
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {

            int item = 0;
            int frame = frameX / 36;

            if (frame == 0)
                item = ModContent.ItemType<Items.Botanic.HangingPlant>();
            else if (frame == 1)
                item = ModContent.ItemType<Items.Botanic.HangingLeafyPlant>();
            else if (frame == 2)
                item = ModContent.ItemType<Items.Botanic.HangingFernPlant>();

            if (item > 0)
                Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 32, 48, item);
        }
    }
}