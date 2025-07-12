using System.Collections.Generic;

using Microsoft.Xna.Framework;

using static GluttonySandbox.Common.AssetLoader;
using static GluttonySandbox.Constants;
using static GluttonySandbox.AssetPathBuilder;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    internal abstract class YoyoItem : ModItem
    {
        public override string Texture => GetTexturePath(nameof(Item), GetType().Name);

        public override void SetDefaults()
        {
            Item.CloneDefaults(ItemID.WoodYoyo);
            SetFields();
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            const byte KnockbackTooltipIndex = 4 + 1;

            // | Why "\u2800"? Because "", " ", "\n" or string.Empty don't work properly.
            TooltipLine tooltipLine = new(Mod, NameOfLogoTooltip, "\u2800");

            tooltips.Insert(KnockbackTooltipIndex, tooltipLine);
        }

        public override void PostDrawTooltipLine(DrawableTooltipLine line)
        {
            if (line.Name != NameOfLogoTooltip) return;

            Vector2 position = new(line.X, line.Y);
            position -= Vector2.One;

            Main.spriteBatch.Draw(UnprldLogoTexture.Value, position, Main.MouseTextColorReal);
        }

        private protected virtual void SetFields() { }
    }
}
