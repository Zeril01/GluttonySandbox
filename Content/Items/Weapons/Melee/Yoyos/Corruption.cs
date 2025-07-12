using Terraria.Enums;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    internal sealed class Corruption : YoyoItem
    {
        private protected override void SetFields()
        {
            Item.SetWeaponValues(15, 4.25f);
            Item.SetShopValues(ItemRarityColor.Blue1, Item.sellPrice(gold: 1));

            Item.shoot = ModContent.ProjectileType<Projectiles.Melee.Yoyos.Corruption>();
        }
    }
}
