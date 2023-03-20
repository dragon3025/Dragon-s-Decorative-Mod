using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace DragonsDecorativeMod.Items.Easter
{
    public class PlasticEgg : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Plastic Egg");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.rare = ItemRarityID.White;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.consumable = true;
            Item.value = Item.sellPrice(0, 0, 7, 50);
            Item.createTile = ModContent.TileType<Tiles.Easter.PlasticEgg>();
        }

        public override void AddRecipes()
        {
            if (!GetInstance<BFurnitureConfig>().PlasticEgg)
            {
                return;
            }

            CreateRecipe(20)
              .AddIngredient(ItemID.RottenEgg, 20)
              .AddIngredient(ItemID.LifeCrystal)
              .AddTile(TileID.DemonAltar)
              .Register();
        }
    }
}