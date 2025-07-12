namespace GluttonySandbox.Common.Conditions
{
    internal sealed class YoyoAbduction : YoyoDropCondition
    {
        private protected override bool IsWorldStateAndZoneMet(Player player) => GluttonySandbox.IsPreHardmode && player.ZoneGlowshroom;

        private protected override string Description => "Drops in Pre-Hardmode from enemies in the Glowing Mushroom biome";
    }
}
