namespace GluttonySandbox.Common.Conditions
{
    internal sealed class YoyoCorruption : YoyoDropCondition
    {
        private protected override bool IsWorldStateAndZoneMet(Player player) => GluttonySandbox.IsPreHardmode && player.ZoneSnow;

        private protected override string Description => "Drops in Pre-Hardmode from enemies in the Snow biome";
    }
}
