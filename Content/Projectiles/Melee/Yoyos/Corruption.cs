using static GluttonySandbox.Utilities.GeneralUtils;
using static GluttonySandbox.Utilities.YoyoProjectileUtils;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    public class Corruption : ModProjectile
    {
        private readonly float _maxSpeed = 12f, _maxRangeInTiles = 11.5f, _lifetimeInSeconds = 5.5f;

        public override string Texture => TexturePath(nameof(Projectile), nameof(Corruption));

        public override void SetStaticDefaults() => SetFields(Type, _maxSpeed, _maxRangeInTiles, _lifetimeInSeconds);

        public override void SetDefaults() => Projectile.CloneDefaults(ProjectileID.WoodYoyo);

        public override void PostAI()
        {
            if (!Main.rand.NextBool(6)) return;

            int dust = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.IceTorch);
            Main.dust[dust].noGravity = true;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (!Main.rand.NextBool(3)) return;

            const int ticksPerSecond = 60;
            int duration = Main.rand.Next(ticksPerSecond, (ticksPerSecond * 3) + 1);

            target.AddBuff(BuffID.Frostburn, duration);
        }
    }
}
