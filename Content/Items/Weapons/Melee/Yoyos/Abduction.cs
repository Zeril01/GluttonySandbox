using Terraria.Enums;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    internal sealed class Abduction : YoyoItem
    {
        private protected override void SetFields()
        {
            Item.SetWeaponValues(15, 4f);
            Item.SetShopValues(ItemRarityColor.Blue1, Item.sellPrice(silver: 75));

            Item.shoot = ModContent.ProjectileType<Projectiles.Melee.Yoyos.Abduction>();
        }
    }
}
