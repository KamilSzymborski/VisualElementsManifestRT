namespace KamilSzymborski.VisualElementsManifestRT.Tools
{
    /// <include file="Tools/.Docs/.ManifestInstaller.xml" path="docs/header"/>
    public static class ManifestInstaller
    {
        #region Methods
        /// <include file="Tools/.Docs/.ManifestInstaller.xml" path="docs/method[@name='Install(string, ManifestComponents, bool)']/*"/>
        public static bool Install(string AppDirectory, ManifestComponents Components, bool ThrowExceptions)
        {
            foreach (var Component in Components.Values)
            {
                var InstallationPath = PathService.CombinePath(AppDirectory, Component.FileName);

                try
                {
                    PathCreator.Create(PathService.GetDirectoryPath(InstallationPath));
                    FileCreator.Create(InstallationPath, Component.Data);
                }
                catch
                {
                    if (ThrowExceptions) throw; else return false;
                }
            }

            return true;
        }
        #endregion
    }
}