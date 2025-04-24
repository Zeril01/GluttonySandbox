namespace GluttonySandbox.Utilities
{
    public static class YoyoProjectileUtils
    {
        private const int _lengthOfTile = 16;

        public static void SetFields(int type, float maxSpeed, float maxRangeInTiles, float lifetimeInSeconds = -1f)
        {
            ProjectileID.Sets.YoyosTopSpeed[type] = maxSpeed;
            ProjectileID.Sets.YoyosMaximumRange[type] = maxRangeInTiles * _lengthOfTile;
            ProjectileID.Sets.YoyosLifeTimeMultiplier[type] = lifetimeInSeconds;
        }
    }
}
