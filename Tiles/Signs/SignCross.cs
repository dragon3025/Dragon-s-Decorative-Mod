﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Tiles.Signs
{
    public class SignCross : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            /*
            //newTile.Width = 2;
            //newTile.Height = 2;
            //newTile.Origin = new Point16(0, 1);
            //newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table | AnchorType.SolidSide, newTile.Width, 0);
            //newTile.UsesCustomCanPlace = true;
            //newTile.CoordinateHeights = new int[2] { 16, 16 };
            //newTile.CoordinateWidth = 16;
            //newTile.CoordinatePadding = 2;
            //newTile.LavaDeath = true;
            //addBaseTile(out Style2x2);
            */

            // Defaults
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16 };
            TileObjectData.newTile.Origin = new Point16(0, 0);
            TileObjectData.newTile.AnchorAlternateTiles = new int[] { 124 };

            // Allow hanging from ceilings
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorLeft = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorRight = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(1);

            // Allow attaching to a solid object that is to the left of the sign
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorLeft = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree, TileObjectData.newTile.Height, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(2);

            // Allow attaching to a solid object that is to the right of the sign
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorRight = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.Tree, TileObjectData.newTile.Height, 0);
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(3);

            // Allow attaching to a wall behind the sign
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.AnchorWall = true;
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.addAlternate(4);

            // Allow attaching sign to the ground
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.addAlternate(0);

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(127, 127, 127));

            TileID.Sets.DisableSmartCursor[Type] = true;
        }

        public override void KillMultiTile(int x, int y, int frameX, int frameY)
        {
            Item.NewItem(new EntitySource_TileBreak(x, y), x * 16, y * 16, 48, 48, ModContent.ItemType<Items.Signs.SignCross>());
        }
    }
}