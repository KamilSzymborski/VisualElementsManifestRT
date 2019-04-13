namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class NameBuilder
    {
        #region Constants
        private const string EXTENSION = "xml";
        private const string SEPARATOR = ".";
        private const string SHORT_NAME = "VisualElementsManifest";
        #endregion

        #region Methods
        internal static string Build(string AppName)
        {
            return string.Format("{0}{3}{1}{3}{2}", AppName, SHORT_NAME, EXTENSION, SEPARATOR);
        }
        #endregion
    }
}