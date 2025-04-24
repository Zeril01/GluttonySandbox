using static GluttonySandbox.Utilities.GeneralUtils;
using static GluttonySandbox.Utilities.YoyoProjectileUtils;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    public class Abduction : ModProjectile
    {
        private readonly float _maxSpeed = 11.5f, _maxRangeInTiles = 11f, _lifetimeInSeconds = 5f;

        public override string Texture => TexturePath(nameof(Projectile), nameof(Abduction));

        public override void SetStaticDefaults() => SetFields(Type, _maxSpeed, _maxRangeInTiles, _lifetimeInSeconds);

        public override void SetDefaults() => Projectile.CloneDefaults(ProjectileID.WoodYoyo);
    }
}
