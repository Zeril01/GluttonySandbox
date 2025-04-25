using Microsoft.Xna.Framework.Graphics;

using ReLogic.Content;

using static GluttonySandbox.Constants;

namespace GluttonySandbox.Common
{
    public class GluttonySandboxSystem : ModSystem
    {
        public static Asset<Texture2D> UnprldLogoTexture
        {
            get;
            private set;
        }

        public override void Load()
        {
            string UnprldLogoPath = AssetPath + NameOfLogoTooltip;

            UnprldLogoTexture = ModContent.Request<Texture2D>(UnprldLogoPath);
        }
    }
}
