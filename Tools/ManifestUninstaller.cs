namespace KamilSzymborski.VisualElementsManifestRT.Tools
{
    /// <include file="Tools/.Docs/.ManifestUninstaller.xml" path="docs/header"/>
    public static class ManifestUninstaller
    {
        /// <include file="Tools/.Docs/.ManifestUninstaller.xml" path="docs/method[@name='Install(string, ManifestCompilationResult, bool)']/*"/>
        public static bool Uninstall(string AppDirectory, ManifestCompilationResult CompilationResult, bool ThrowExceptions = false)
        {
            return Uninstall(AppDirectory, CompilationResult as ManifestComponents, ThrowExceptions);
        }
        /// <include file="Tools/.Docs/.ManifestUninstaller.xml" path="docs/method[@name='Install(string, ManifestProcessingResult, bool)']/*"/>
        public static bool Uninstall(string AppDirectory, ManifestProcessingResult ProcessingResult, bool ThrowExceptions = false)
        {
            return Uninstall(AppDirectory, ProcessingResult as ManifestComponents, ThrowExceptions);
        }

        private static bool Uninstall(string AppDirectory, ManifestComponents Components, bool ThrowExceptions)
        {
            foreach (var Component in Components.Values)
            {
                var Path = PathService.CombinePath(AppDirectory, Component.FileName);

                try
                {
                    if (FileService.Exists(Path)) FileDeleter.Delete(Path);
                }
                catch
                {
                    if (ThrowExceptions) throw; else return false;
                }
            }

            return true;
        }
    }
}