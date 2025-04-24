using System.Collections.Generic;

using GluttonySandbox.Common.Systems;

using Microsoft.Xna.Framework;

namespace GluttonySandbox.Utilities
{
    public static class YoyoItemUtils
    {
        private static readonly string _name = GluttonySandbox.NameOfLogoTooltip;

        public static void InsertEmptyTooltip(Mod mod, List<TooltipLine> tooltips)
        {
            const int numberOfKnockbackTooltip = 5;

            // | Why "\u2800"? Because "", " ", "\n" or string.Empty don't work properly.
            TooltipLine tooltipLine = new(mod, _name, "\u2800");

            tooltips.Insert(numberOfKnockbackTooltip, tooltipLine);
        }

        public static void DrawUnprldLogo(DrawableTooltipLine line)
        {
            if (line.Name != _name) return;

            const int paddingForLogo = 1;
            Vector2 position = new(line.X - paddingForLogo, line.Y - paddingForLogo);

            Main.spriteBatch.Draw(GluttonySandboxSystem.UnprldLogoTexture.Value, position, Main.MouseTextColorReal);
        }
    }
}
