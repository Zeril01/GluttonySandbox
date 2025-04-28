using GluttonySandbox.Content.Items.Weapons.Melee.Yoyos;

using Terraria.GameContent.ItemDropRules;

using static GluttonySandbox.Common.Conditions;

namespace GluttonySandbox.Common
{
    public class Globalist : GlobalNPC
    {
        public override void ModifyGlobalLoot(GlobalLoot globalLoot)
        {
            void AddYoyo(IItemDropRuleCondition condition, int itemType) => globalLoot.Add(ItemDropRule.ByCondition(condition, itemType, chanceDenominator: 200));

            AddYoyo(new YoyoAbduction(), ModContent.ItemType<Abduction>());
            AddYoyo(new YoyoCorruption(), ModContent.ItemType<Corruption>());
            AddYoyo(new YoyoElimination(), ModContent.ItemType<Elimination>());
        }
    }
}
