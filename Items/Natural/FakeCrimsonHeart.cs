using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DragonsDecorativeMod.Items.Natural
{
    public class FakeCrimsonHeart : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimson Heart Object");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Natural.FakeCrimsonHeart>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
              .AddIngredient(ItemID.FleshBlock, 10)
              .AddIngredient(ItemID.SoulofNight)
              .AddTile(TileID.CrystalBall)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}