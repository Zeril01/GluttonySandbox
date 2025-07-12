using static GluttonySandbox.Constants;

namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    internal sealed class Corruption : YoyoProjectile
    {
        private protected override float MaxSpeed => 12f;
        private protected override float MaxRangeInTiles => 11.5f;
        private protected override float LifetimeInSeconds => 5.5f;

        public override void PostAI()
        {
            if (!Main.rand.NextBool(6)) return;

            ushort dust = (ushort)Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.IceTorch);
            Main.dust[dust].noGravity = true;
        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (!Main.rand.NextBool(3)) return;

            byte duration = (byte)Main.rand.Next(TicksPerSecond, (TicksPerSecond * 3) + 1);

            target.AddBuff(BuffID.Frostburn, duration);
        }
    }
}
