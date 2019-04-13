using System.IO;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class PathService
    {
        #region Methods
        internal static string CombineName(string Name, string Extension)
        {
            return Path.ChangeExtension(Name, Extension);
        }
        internal static string CombinePath(string Part1, string Part2)
        {
            return Path.Combine(Part1, Part2);
        }
        internal static string GetFileName(string FilePath)
        {
            return Path.GetFileName(FilePath);
        }
        internal static string GetFileExtension(string FilePath)
        {
            return Path.GetExtension(FilePath).Substring(1);
        }
        internal static string GetShortName(string FilePath)
        {
            return Path.GetFileNameWithoutExtension(FilePath);
        }
        internal static string GetDirectoryPath(string FilePath)
        {
            return Path.GetDirectoryName(FilePath);
        }
        internal static string DetermineFullPath(string DirectoryPath, string FilePath)
        {
            return Path.IsPathRooted(FilePath) ? FilePath : Path.Combine(DirectoryPath, FilePath);
        }
        #endregion
    }
}