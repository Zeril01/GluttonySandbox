using System.Collections.Generic;

using Terraria.Enums;

using static GluttonySandbox.Utilities.GeneralUtility;
using static GluttonySandbox.Utilities.YoyoItemUtility;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    public class Corruption : ModItem
    {
        public override string Texture => GetTexturePath(nameof(Item), nameof(Corruption));

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.WoodYoyo);
            Item.SetWeaponValues(16, 4.25f);
            Item.SetShopValues(ItemRarityColor.Blue1, Item.sellPrice(gold: 1));

            Item.shoot = ModContent.ProjectileType<Projectiles.Melee.Yoyos.Corruption>();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) => InsertEmptyTooltip(Mod, tooltips);

        public override void PostDrawTooltipLine(DrawableTooltipLine line) => DrawUnprldLogo(line);
    }
}
