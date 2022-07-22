﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DragonsDecorativeMod.Items.Natural.Ambient.MediumD
{
    public class SmallLivingWoodRoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Small Living Wood Roots");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 10;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.MediumD>();
            Item.placeStyle = 6;
        }

        public override void OnConsumeItem(Player player)
        {
            Item.placeStyle = 6 + Main.rand.Next(3);
            base.OnConsumeItem(player);
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.Wood, 7)
              .AddTile(TileID.LivingLoom)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}