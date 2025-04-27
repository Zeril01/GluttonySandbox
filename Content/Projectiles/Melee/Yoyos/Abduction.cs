using static GluttonySandbox.Content.Projectiles.Melee.Yoyos.Setter;
using static GluttonySandbox.PathFinder;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    public class Abduction : ModProjectile
    {
        private readonly Stats _stats = new()
        {
            MaxSpeed = 11.5f,
            MaxRangeInTiles = 11f,
            LifetimeInSeconds = 5f
        };

        public override string Texture => GetTexturePath(nameof(Projectile), nameof(Abduction));

        public override void SetStaticDefaults() => SetFields(Type, _stats);

        public override void SetDefaults() => Projectile.CloneDefaults(ProjectileID.WoodYoyo);
    }
}
