namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    internal sealed class Elimination : YoyoProjectile
    {
        private protected override float MaxSpeed => 12.5f;
        private protected override float MaxRangeInTiles => 10.5f;
        private protected override float LifetimeInSeconds => 5.25f;
    }
}
