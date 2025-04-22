using static GluttonySandbox.Utilities.GeneralUtils;
using static GluttonySandbox.Utilities.YoyoProjectileUtils;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    public class Abduction : ModProjectile
    {
        public override string Texture => TexturePath(nameof(Projectile), nameof(Abduction));

        public override void SetStaticDefaults() => SetFields(Type, 5f, 11f, 11.5f);

        public override void SetDefaults() => Projectile.CloneDefaults(ProjectileID.WoodYoyo);
    }
}
