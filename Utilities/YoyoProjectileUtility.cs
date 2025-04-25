namespace GluttonySandbox.Utilities
{
    public static class YoyoProjectileUtility
    {
        public static void SetFields(int type, float maxSpeed, float maxRangeInTiles, float lifetimeInSeconds = -1f)
        {
            const int WidthOfAnyBlock = 16;

            ProjectileID.Sets.YoyosTopSpeed[type] = maxSpeed;
            ProjectileID.Sets.YoyosMaximumRange[type] = maxRangeInTiles * WidthOfAnyBlock;
            ProjectileID.Sets.YoyosLifeTimeMultiplier[type] = lifetimeInSeconds;
        }
    }
}
