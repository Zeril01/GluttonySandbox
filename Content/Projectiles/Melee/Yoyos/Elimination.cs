using static GluttonySandbox.Content.Projectiles.Melee.Yoyos.Setter;
using static GluttonySandbox.PathFinder;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    public class Elimination : ModProjectile
    {
        private readonly Stats _stats = new()
        {
            MaxSpeed = 12.5f,
            MaxRangeInTiles = 10.5f,
            LifetimeInSeconds = 5.25f
        };

        public override string Texture => GetTexturePath(nameof(Projectile), nameof(Elimination));

        public override void SetStaticDefaults() => SetFields(Type, _stats);

        public override void SetDefaults() => Projectile.CloneDefaults(ProjectileID.WoodYoyo);
    }
}
