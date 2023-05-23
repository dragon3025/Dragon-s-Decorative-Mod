using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class LargePot : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Large Pot");
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
            Item.value = Item.sellPrice(0, 0, 1);
            Item.createTile = ModContent.TileType<Tiles.LargePot>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().LargePot)
            {
                return;
            }

            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.IronBar, 10)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}