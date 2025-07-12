using static GluttonySandbox.Constants;

namespace GluttonySandbox
{
    internal static class AssetPathBuilder
    {
        internal static string GetTexturePath(string entityType, string entityName) => $"{AssetPath}{entityType}s/{entityName}";
    }
}
