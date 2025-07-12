namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    internal sealed class Abduction : YoyoProjectile
    {
        private protected override float MaxSpeed => 11.5f;
        private protected override float MaxRangeInTiles => 11f;
        private protected override float LifetimeInSeconds => 5f;
    }
}
