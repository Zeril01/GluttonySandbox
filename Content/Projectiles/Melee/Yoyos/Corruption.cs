using static GluttonySandbox.Constants;
using static GluttonySandbox.Content.Projectiles.Melee.Yoyos.Setter;
using static GluttonySandbox.PathFinder;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    public class Corruption : ModProjectile
    {
        private readonly Stats _stats = new()
        {
            MaxSpeed = 12f,
            MaxRangeInTiles = 11.5f,
            LifetimeInSeconds = 5.5f
        };

        public override string Texture => GetTexturePath(nameof(Projectile), nameof(Corruption));

        public override void SetStaticDefaults() => SetFields(Type, _stats);

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

            int duration = Main.rand.Next(TicksPerSecond, (TicksPerSecond * 3) + 1);

            target.AddBuff(BuffID.Frostburn, duration);
        }
    }
}
