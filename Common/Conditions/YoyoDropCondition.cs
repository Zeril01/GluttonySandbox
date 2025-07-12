using Terraria.GameContent.ItemDropRules;

namespace GluttonySandbox.Common.Conditions
{
    internal abstract class YoyoDropCondition : IItemDropRuleCondition
    {
        private protected abstract string Description { get; }

        private protected abstract bool IsWorldStateAndZoneMet(Player player);

        public bool CanDrop(DropAttemptInfo info)
        {
            return IsWorldStateAndZoneMet(info.player)
                   && !info.npc.CountsAsACritter
                   && !info.npc.friendly;
        }

        public bool CanShowItemDropInUI() => true;

        public string GetConditionDescription() => Description;
    }
}
