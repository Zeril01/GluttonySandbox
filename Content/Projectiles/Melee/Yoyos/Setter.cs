namespace GluttonySandbox.Content.Projectiles.Melee.Yoyos
{
    public static class Setter
    {
        public static void SetFields(int type, Stats stats)
        {
            const int WidthOfAnyBlock = 16;

            ProjectileID.Sets.YoyosTopSpeed[type] = stats.MaxSpeed;
            ProjectileID.Sets.YoyosMaximumRange[type] = stats.MaxRangeInTiles * WidthOfAnyBlock;
            ProjectileID.Sets.YoyosLifeTimeMultiplier[type] = stats.LifetimeInSeconds;
        }
    }
}
