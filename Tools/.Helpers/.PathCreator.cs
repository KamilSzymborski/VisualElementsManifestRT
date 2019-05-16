using NetUtils = System.IO;


namespace KamilSzymborski.VisualElementsManifestRT.Tools
{
    internal static class PathCreator
    {
        #region Methods
        internal static void Create(string Path)
        {
            NetUtils.Directory.CreateDirectory(Path);
        }
        #endregion
    }
}