using Net = System.IO;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class PathService
    {
        #region Methods
        internal static string CombineName(string Name, string Extension)
        {
            return Net.Path.ChangeExtension(Name, Extension);
        }
        internal static string CombinePath(string Part1, string Part2)
        {
            return Net.Path.Combine(Part1, Part2);
        }
        internal static string GetFileName(string Path)
        {
            return Net.Path.GetFileName(Path);
        }
        internal static string GetFileExtension(string Path)
        {
            return Net.Path.GetExtension(Path).Substring(1);
        }
        internal static string GetShortName(string Path)
        {
            return Net.Path.GetFileNameWithoutExtension(Path);
        }
        internal static string GetDirectoryPath(string Path)
        {
            return Net.Path.GetDirectoryName(Path);
        }
        #endregion
    }
}