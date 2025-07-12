using static GluttonySandbox.AssetPathBuilder;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    internal abstract class YoyoProjectile : ModProjectile
    {
        private protected abstract float MaxSpeed { get; }
        private protected abstract float MaxRangeInTiles { get; }
        private protected abstract float LifetimeInSeconds { get; }

        public override string Texture => GetTexturePath(nameof(Projectile), GetType().Name);

        public override void SetStaticDefaults()
        {
            const byte WidthOfAnyBlock = 16;

            ProjectileID.Sets.YoyosTopSpeed[Type] = MaxSpeed;
            ProjectileID.Sets.YoyosMaximumRange[Type] = MaxRangeInTiles * WidthOfAnyBlock;
            ProjectileID.Sets.YoyosLifeTimeMultiplier[Type] = LifetimeInSeconds;
        }

        public override void SetDefaults() => Projectile.CloneDefaults(ProjectileID.WoodYoyo);
    }
}
