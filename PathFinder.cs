using static GluttonySandbox.Constants;

namespace GluttonySandbox
{
    public static class PathFinder
    {
        public static string GetTexturePath(string typeOfEntity, string nameOfClass) => $"{AssetPath}{typeOfEntity}s/{nameOfClass}";
    }
}
