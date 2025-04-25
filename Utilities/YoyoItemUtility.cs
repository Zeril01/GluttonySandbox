using System.Collections.Generic;

using GluttonySandbox.Common;

using Microsoft.Xna.Framework;

using static GluttonySandbox.Constants;

namespace GluttonySandbox.Utilities
{
    public static class YoyoItemUtility
    {
        public static void InsertEmptyTooltip(Mod mod, List<TooltipLine> tooltips)
        {
            const int NumberOfKnockbackTooltip = 5;

            // | Why "\u2800"? Because "", " ", "\n" or string.Empty don't work properly.
            TooltipLine tooltipLine = new(mod, NameOfLogoTooltip, "\u2800");

            tooltips.Insert(NumberOfKnockbackTooltip, tooltipLine);
        }

        public static void DrawUnprldLogo(DrawableTooltipLine line)
        {
            if (line.Name != NameOfLogoTooltip) return;

            const int PaddingForLogo = 1;
            Vector2 position = new(line.X - PaddingForLogo, line.Y - PaddingForLogo);

            Main.spriteBatch.Draw(GluttonySandboxSystem.UnprldLogoTexture.Value, position, Main.MouseTextColorReal);
        }
    }
}
