namespace KamilSzymborski.VisualElementsManifestRT.Tools
{
    /// <include file="Tools/.Docs/.ManifestInstaller.xml" path="docs/header"/>
    public static class ManifestInstaller
    {
        #region Methods
        /// <include file="Tools/.Docs/.ManifestInstaller.xml" path="docs/method[@name='Install(string, ManifestCompilationResult, bool)']/*"/>
        public static bool Install(string AppDirectory, ManifestCompilationResult CompilationResult, bool ThrowExceptions = false)
        {
            return Install(AppDirectory, CompilationResult as ManifestComponents, ThrowExceptions);
        }
        /// <include file="Tools/.Docs/.ManifestInstaller.xml" path="docs/method[@name='Install(string, ManifestProcessingResult, bool)']/*"/>
        public static bool Install(string AppDirectory, ManifestProcessingResult ProcessingResult, bool ThrowExceptions = false)
        {
            return Install(AppDirectory, ProcessingResult as ManifestComponents, ThrowExceptions);
        }

        private static bool Install(string AppDirectory, ManifestComponents Components, bool ThrowExceptions)
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