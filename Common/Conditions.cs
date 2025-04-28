using Terraria.GameContent.ItemDropRules;

namespace GluttonySandbox.Common
{
    public static class Conditions
    {
        public abstract class BaseYoyoCondition : IItemDropRuleCondition
        {
            private protected abstract bool IsZoneConditionMet(Player player);

            private protected abstract string SetDescription();

            public bool CanDrop(DropAttemptInfo info)
            {
                return !Main.hardMode
                       && IsZoneConditionMet(info.player)
                       && !info.npc.CountsAsACritter
                       && !info.npc.friendly;
            }

            public bool CanShowItemDropInUI() => true;

            public string GetConditionDescription() => SetDescription();
        }

        public class YoyoAbduction : BaseYoyoCondition
        {
            private protected override bool IsZoneConditionMet(Player player) => player.ZoneGlowshroom;

            private protected override string SetDescription() => "Drops in Pre-Hardmode from enemies in the Glowing Mushroom biome";
        }

        public class YoyoCorruption : BaseYoyoCondition
        {
            private protected override bool IsZoneConditionMet(Player player) => player.ZoneSnow;

            private protected override string SetDescription() => "Drops in Pre-Hardmode from enemies in the Snow biome";
        }

        public class YoyoElimination : BaseYoyoCondition
        {
            private protected override bool IsZoneConditionMet(Player player) => player.ZoneDesert || player.ZoneUndergroundDesert;

            private protected override string SetDescription() => "Drops in Pre-Hardmode from enemies in the Desert biome";
        }
    }
}
