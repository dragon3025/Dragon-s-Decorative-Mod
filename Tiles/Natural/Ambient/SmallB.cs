﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;

namespace DragonsDecorativeMod.Tiles.Natural.Ambient
{
    public class SmallB : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));
        }

        public override bool Drop(int i, int j)
        {
            Tile t = Main.tile[i, j];
            int frame = t.TileFrameX / 18;
            int itemID = 0;

            if (frame <= 3)
                itemID = ModContent.ItemType<Items.Natural.Ambient.SmallB.TinyBloodySkull>();
            else if (frame <= 7)
                itemID = ModContent.ItemType<Items.Natural.Ambient.SmallB.TinyBloodyBonePile>();
            else if (frame <= 12)
                itemID = ModContent.ItemType<Items.Natural.Ambient.SmallB.BrokenTool>();
            else if (frame <= 15)
                itemID = ModContent.ItemType<Items.Natural.Ambient.SmallB.BrokenArrow>();

            if (itemID > 0)
                Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, itemID);

            return base.Drop(i, j);
        }
    }
}