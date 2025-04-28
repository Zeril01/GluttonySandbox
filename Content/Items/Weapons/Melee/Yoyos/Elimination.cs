using System.Collections.Generic;

using Terraria.Enums;

using static GluttonySandbox.Content.Items.Weapons.Melee.Yoyos.TooltipHelper;
using static GluttonySandbox.PathFinder;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    public class Elimination : ModItem
    {
        public override string Texture => GetTexturePath(nameof(Item), nameof(Elimination));

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.WoodYoyo);
            Item.SetWeaponValues(16, 4.75f);
            Item.SetShopValues(ItemRarityColor.Blue1, Item.sellPrice(gold: 1));

            Item.shoot = ModContent.ProjectileType<Projectiles.Melee.Yoyos.Elimination>();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) => InsertEmptyTooltip(Mod, tooltips);

        public override void PostDrawTooltipLine(DrawableTooltipLine line) => DrawUnprldLogo(line);
    }
}
