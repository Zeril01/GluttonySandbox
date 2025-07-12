namespace GluttonySandbox.Common.Conditions
{
    internal sealed class YoyoElimination : YoyoDropCondition
    {
        private protected override bool IsWorldStateAndZoneMet(Player player) => GluttonySandbox.IsPreHardmode && (player.ZoneDesert || player.ZoneUndergroundDesert);

        private protected override string Description => "Drops in Pre-Hardmode from enemies in the Desert biome";
    }
}
