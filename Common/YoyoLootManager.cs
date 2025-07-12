using GluttonySandbox.Common.Conditions;
using GluttonySandbox.Content.Items.Weapons.Melee.Yoyos;

using Terraria.GameContent.ItemDropRules;

namespace GluttonySandbox.Common
{
    internal sealed class YoyoLootManager : GlobalNPC
    {
        public override void ModifyGlobalLoot(GlobalLoot globalLoot)
        {
            void AddYoyoDropRule(IItemDropRuleCondition condition, int itemType) => globalLoot.Add(ItemDropRule.ByCondition(condition, itemType, chanceDenominator: 200));

            AddYoyoDropRule(new YoyoAbduction(), ModContent.ItemType<Abduction>());
            AddYoyoDropRule(new YoyoCorruption(), ModContent.ItemType<Corruption>());
            AddYoyoDropRule(new YoyoElimination(), ModContent.ItemType<Elimination>());
        }
    }
}
