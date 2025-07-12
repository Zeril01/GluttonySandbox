using Terraria.Enums;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    internal sealed class Elimination : YoyoItem
    {
        private protected override void SetFields()
        {
            Item.SetWeaponValues(16, 4.75f);
            Item.SetShopValues(ItemRarityColor.Blue1, Item.sellPrice(gold: 1));

            Item.shoot = ModContent.ProjectileType<Projectiles.Melee.Yoyos.Elimination>();
        }
    }
}
