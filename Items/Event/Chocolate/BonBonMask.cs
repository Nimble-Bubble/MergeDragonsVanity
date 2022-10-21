using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MergeDragonsVanity.Items.Event.Chocolate
{
    [AutoloadEquip(EquipType.Head)]
    public class BonBonMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bon-Bon Dragon Mask");
            Tooltip.SetDefault("A mask of a dragon who is a cute little treat.");
        }
        public override void SetDefaults()
        {
            Item.width = 30;
            Item.height = 22;
            Item.value = 25000;
            Item.rare = ItemRarityID.Blue;
            Item.vanity = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Ale, 5);
            recipe.AddIngredient(ItemID.BrownDye, 1);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(TileID.Loom);
            recipe.Register();
        }
    }
}