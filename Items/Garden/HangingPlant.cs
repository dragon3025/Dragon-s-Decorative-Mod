﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Garden
{
    public class HangingPlant : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hanging Plant");
            Tooltip.SetDefault("NOT AFFECTED BY WIND");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 36;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 25);
            Item.createTile = ModContent.TileType<Tiles.Garden.HangingPlant>();
            Item.placeStyle = 0;
        }
    }
}