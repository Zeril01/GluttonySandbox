using System.Collections.Generic;

using Microsoft.Xna.Framework;

using static GluttonySandbox.Constants;

namespace GluttonySandbox.Content.Items.Weapons.Melee.Yoyos
{
    public static class TooltipHelper
    {
        private const int _NumberOfKnockbackTooltip = 5;

        public static void InsertEmptyTooltip(Mod mod, List<TooltipLine> tooltips)
        {
            // | Why "\u2800"? Because "", " ", "\n" or string.Empty don't work properly.
            TooltipLine tooltipLine = new(mod, NameOfLogoTooltip, "\u2800");

            tooltips.Insert(_NumberOfKnockbackTooltip, tooltipLine);
        }

        public static void DrawUnprldLogo(DrawableTooltipLine line)
        {
            if (line.Name != NameOfLogoTooltip) return;

            const int PaddingForLogo = 1;
            Vector2 position = new(line.X - PaddingForLogo, line.Y - PaddingForLogo);

            Main.spriteBatch.Draw(Common.Loader.UnprldLogoTexture.Value, position, Main.MouseTextColorReal);
        }
    }
}
