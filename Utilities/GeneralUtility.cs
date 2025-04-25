using static GluttonySandbox.Constants;

namespace GluttonySandbox.Utilities
{
    public static class GeneralUtility
    {
        public static string GetTexturePath(string typeOfEntity, string nameOfClass) => $"{AssetPath}{typeOfEntity}s/{nameOfClass}";
    }
}
