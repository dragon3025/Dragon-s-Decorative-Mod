﻿using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural.Ambient.LargeB
{
    public class AshPilesWithHellstone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ash Piles With Hellstone");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = 0;
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.LargeB>();
            Item.placeStyle = 6;
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = 6 + Main.rand.Next(3);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().OtherAmbient)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ItemID.Hellstone)
              .AddTile(TileID.HeavyWorkBench)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}