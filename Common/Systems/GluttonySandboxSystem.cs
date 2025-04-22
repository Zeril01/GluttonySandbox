using Microsoft.Xna.Framework.Graphics;

using ReLogic.Content;

namespace GluttonySandbox.Common.Systems
{
    public class GluttonySandboxSystem : ModSystem
    {
        private const string _unprldLogoPath = GluttonySandbox.AssetPath + GluttonySandbox.NameOfLogoTooltip;

        public static Asset<Texture2D> UnprldLogoTexture
        {
            get;
            private set;
        }

        public override void Load() => UnprldLogoTexture = ModContent.Request<Texture2D>(_unprldLogoPath);
    }
}
