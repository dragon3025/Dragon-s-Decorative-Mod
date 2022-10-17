﻿using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural.Ambient.LargeStalactites
{
    public class LargeStoneStalactite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Large Stone Stalactite");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
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
            Item.createTile = ModContent.TileType<Tiles.Natural.Ambient.LargeStalactites>();
            Item.placeStyle = 3;
        }

        public override bool? UseItem(Player player)
        {
            Item.placeStyle = Main.rand.Next(3, 6);
            return base.UseItem(player);
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().StalagmitesAndStalactites)
                return;

            CreateRecipe()
                .AddIngredient(ItemID.StoneBlock)
                .AddTile(TileID.HeavyWorkBench)
                .AddCondition(Recipe.Condition.InGraveyardBiome)
                .Register();
        }
    }
}