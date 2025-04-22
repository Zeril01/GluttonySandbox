namespace GluttonySandbox.Utilities
{
    public static class GeneralUtils
    {
        public static string TexturePath(string typeOfEntity, string nameOfClass) => $"{GluttonySandbox.AssetPath}{typeOfEntity}s/{nameOfClass}";
    }
}
