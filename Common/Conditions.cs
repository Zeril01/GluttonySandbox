using Terraria.GameContent.ItemDropRules;

namespace GluttonySandbox.Common
{
    public static class Conditions
    {
        public class YoyoAbduction : IItemDropRuleCondition
        {
            public bool CanDrop(DropAttemptInfo info) => !Main.hardMode && info.npc.HasPlayerTarget && info.player.ZoneGlowshroom && info.npc.lifeMax > 5 && !info.npc.friendly && info.npc.value > 0f;

            public bool CanShowItemDropInUI() => true;

            public string GetConditionDescription() => null;
        }

        public class YoyoCorruption : IItemDropRuleCondition
        {
            public bool CanDrop(DropAttemptInfo info) => !Main.hardMode && info.npc.HasPlayerTarget && info.player.ZoneSnow && info.npc.lifeMax > 5 && !info.npc.friendly && info.npc.value > 0f;

            public bool CanShowItemDropInUI() => true;

            public string GetConditionDescription() => null;
        }
    }
}
