using NetUtils = System.IO;


namespace KamilSzymborski.VisualElementsManifestRT.Tools
{
    internal static class FileDeleter
    {
        #region Methods
        internal static void Delete(string Path)
        {
            NetUtils.File.Delete(Path);
        }
        #endregion
    }
}