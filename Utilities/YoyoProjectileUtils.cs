namespace GluttonySandbox.Utilities
{
    public static class YoyoProjectileUtils
    {
        private const int _lengthOfTile = 16;

        public static void SetFields(int type, float lifetimeInSeconds, float maxRangeInTiles, float maxSpeed)
        {
            ProjectileID.Sets.YoyosLifeTimeMultiplier[type] = lifetimeInSeconds;
            ProjectileID.Sets.YoyosMaximumRange[type] = maxRangeInTiles * _lengthOfTile;
            ProjectileID.Sets.YoyosTopSpeed[type] = maxSpeed;
        }
    }
}
