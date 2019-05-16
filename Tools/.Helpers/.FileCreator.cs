using NetUtils = System.IO;


namespace KamilSzymborski.VisualElementsManifestRT.Tools
{
    internal static class FileCreator
    {
        #region Methods
        internal static void Create(string Path, byte[] Data)
        {
            NetUtils.File.WriteAllBytes(Path, Data);
        }
        #endregion
    }
}