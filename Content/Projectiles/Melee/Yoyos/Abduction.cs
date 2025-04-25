using static GluttonySandbox.Utilities.GeneralUtility;
using static GluttonySandbox.Utilities.YoyoProjectileUtility;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    public class Abduction : ModProjectile
    {
        public override string Texture => GetTexturePath(nameof(Projectile), nameof(Abduction));

        public override void SetStaticDefaults() => SetFields(Type, maxSpeed: 11.5f, maxRangeInTiles: 11f, lifetimeInSeconds: 5f);

        public override void SetDefaults() => Projectile.CloneDefaults(ProjectileID.WoodYoyo);
    }
}
