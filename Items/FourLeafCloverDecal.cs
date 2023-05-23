using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items
{
    public class FourLeafCloverDecal : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Four-Leaf Clover Decal");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 42;
            Item.height = 38;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 0, 10);
            Item.createTile = ModContent.TileType<Tiles.FourLeafCloverDecal>();
            Item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().CloverDecal)
            {
                return;
            }

            CreateRecipe()
              .AddIngredient(ModContent.ItemType<Items.CloverDecal>())
              .Register();
        }
    }
}