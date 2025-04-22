using System.Collections.Generic;

using Terraria.Enums;

using static GluttonySandbox.Utilities.YoyoItemUtils;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    public class Abduction : ModItem
    {
        public override string Texture => GluttonySandbox.AssetPath + "Items/" + nameof(Abduction);

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.WoodYoyo);
            Item.SetWeaponValues(15, 4f);
            Item.SetShopValues(ItemRarityColor.Blue1, Item.sellPrice(silver: 75));

            // | Item.shoot = ModContent.ProjectileType<Projectiles.Yoyos.Abduction>();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips) => InsertEmptyTooltipForLogo(Mod, tooltips);

        public override void PostDrawTooltipLine(DrawableTooltipLine line) => DrawUnprldLogo(line);
    }
}
