using KamilSzymborski.VisualElementsManifest.Tools;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestService.xml" path="docs/header"/>
    public static class ManifestService
    {
        #region Methods
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Process(string)']/*"/>
        public static ManifestProcessingResult Process(string Path)
        {
            return Processer.Process(Path);
        }
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Process(string, string)']/*"/>
        public static ManifestProcessingResult Process(string AppDirectory, string AppName)
        {
            return Processer.Process(PathService.CombinePath(AppDirectory, ManifestNameBuilder.Build(AppName)));
        }
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Compile(string, int, bool, bool)']/*"/>
        public static ManifestCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo)
        {
            return Compiler.Compile(AppName, BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo);
        }
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Compile(string, int, bool, bool, byte[], byte[], string, string, string, string, string, string)']/*"/>
        public static ManifestCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, string Square70x70LogoName, string Square150x150LogoName, string OptionalSquare70x70LogoFormat = null, string OptionalSquare150x150LogoFormat = null, string OptionalSquare70x70LogoDirectoryPath = null, string OptionalSquare150x150LogoDirectoryPath = null)
        {
            return Compiler.Compile(AppName, BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo, Square70x70LogoData, Square150x150LogoData, Square70x70LogoName, Square150x150LogoName, OptionalSquare70x70LogoFormat, OptionalSquare150x150LogoFormat, OptionalSquare70x70LogoDirectoryPath, OptionalSquare150x150LogoDirectoryPath);
        }
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Decompile(ManifestRTProcessingResult ProcessingResult)']/*"/>
        public static ManifestDecompilationResult Decompile(ManifestProcessingResult ProcessingResult)
        {
            return Decompiler.Decompile(ProcessingResult);
        }
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='Decompile(ManifestRTCompilationResult CompilationResult)']/*"/>
        public static ManifestDecompilationResult Decompile(ManifestCompilationResult CompilationResult)
        {
            return Decompiler.Decompile(CompilationResult);
        }
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='CanBeProcessed(string)']/*"/>
        public static bool CanBeProcessed(string Path)
        {
            return Processer.CanBeProcessed(Path);
        }
        /// <include file=".Docs/.ManifestService.xml" path="docs/method[@name='CanBeProcessed(string, string)']/*"/>
        public static bool CanBeProcessed(string AppDirectory, string AppName)
        {
            return Processer.CanBeProcessed(PathService.CombinePath(AppDirectory, ManifestNameBuilder.Build(AppName)));
        }
        #endregion
    }
}