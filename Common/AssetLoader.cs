using Microsoft.Xna.Framework.Graphics;

using ReLogic.Content;

using static GluttonySandbox.Constants;

namespace GluttonySandbox.Common
{
    internal sealed class AssetLoader : ModSystem
    {
        internal static Asset<Texture2D> UnprldLogoTexture { get; private set; }

        public override void Load()
        {
            const string UnprldLogoPath = AssetPath + NameOfLogoTooltip;

            UnprldLogoTexture = ModContent.Request<Texture2D>(UnprldLogoPath);
        }
    }
}
