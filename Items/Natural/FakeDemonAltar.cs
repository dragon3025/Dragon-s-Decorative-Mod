using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Natural
{
    public class FakeDemonAltar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fake Demon Altar");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 28;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Natural.FakeDemonAltar>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().AltarsShadowOrbAndCrimsonHeart)
                return;

            CreateRecipe()
              .AddIngredient(ItemID.EbonstoneBlock)
              .AddTile(TileID.CrystalBall)
              .AddCondition(Recipe.Condition.InGraveyardBiome)
              .Register();
        }
    }
}