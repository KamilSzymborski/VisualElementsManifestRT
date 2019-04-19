namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestRTService.xml" path="docs/header"/>
    public static class ManifestRTService
    {
        #region Methods
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Process(string)']/*"/>
        public static ManifestRTProcessingResult Process(string Path)
        {
            return Processer.Process(Path);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Process(string, string)']/*"/>
        public static ManifestRTProcessingResult Process(string AppDirectory, string AppName)
        {
            return Processer.Process(PathService.CombinePath(AppDirectory, NameBuilder.Build(AppName)));
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Compile(string, int, bool, bool)']/*"/>
        public static ManifestRTCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo)
        {
            return Compiler.Compile(AppName, BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Compile(string, int, bool, bool, byte[], byte[], string, string, string, string)']/*"/>
        public static ManifestRTCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, string Square70x70LogoName, string Square150x150LogoName, string Square70x70LogoFormat, string Square150x150LogoFormat)
        {
            return Compiler.Compile(AppName, BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo, Square70x70LogoData, Square150x150LogoData, Square70x70LogoName, Square150x150LogoName, Square70x70LogoFormat, Square150x150LogoFormat, string.Empty, string.Empty);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Compile(string, int, bool, bool, byte[], byte[], string, string, string, string, string, string)']/*"/>
        public static ManifestRTCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, string Square70x70LogoName, string Square150x150LogoName, string Square70x70LogoFormat, string Square150x150LogoFormat, string Square70x70LogoDirectoryPath, string Square150x150LogoDirectoryPath)
        {
            return Compiler.Compile(AppName, BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo, Square70x70LogoData, Square150x150LogoData, Square70x70LogoName, Square150x150LogoName, Square70x70LogoFormat, Square150x150LogoFormat, Square70x70LogoDirectoryPath, Square150x150LogoDirectoryPath);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Compile(string, int, bool, bool, byte[], byte[], bool, string, string)']/*"/>
        public static ManifestRTCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, bool AutodetectFormat, string Square70x70LogoName, string Square150x150LogoName)
        {
            return Compiler.Compile(AppName, BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo, Square70x70LogoData, Square150x150LogoData, AutodetectFormat? Square70x70LogoName : PathService.GetShortName(Square70x70LogoName), AutodetectFormat ? Square150x150LogoName : PathService.GetShortName(Square150x150LogoName), AutodetectFormat? ImageService.GetKnownFormat(Square70x70LogoData) : PathService.GetFileExtension(Square70x70LogoName), AutodetectFormat ? ImageService.GetKnownFormat(Square150x150LogoData) : PathService.GetFileExtension(Square150x150LogoName), string.Empty, string.Empty);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Compile(string, int, bool, bool, byte[], byte[], bool, string, string, string, string)']/*"/>
        public static ManifestRTCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, bool AutodetectFormat, string Square70x70LogoName, string Square150x150LogoName, string Square70x70LogoDirectoryPath, string Square150x150LogoDirectoryPath)
        {
            return Compiler.Compile(AppName, BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo, Square70x70LogoData, Square150x150LogoData, AutodetectFormat ? Square70x70LogoName : PathService.GetShortName(Square70x70LogoName), AutodetectFormat ? Square150x150LogoName : PathService.GetShortName(Square150x150LogoName), AutodetectFormat ? ImageService.GetKnownFormat(Square70x70LogoData) : PathService.GetFileExtension(Square70x70LogoName), AutodetectFormat ? ImageService.GetKnownFormat(Square150x150LogoData) : PathService.GetFileExtension(Square150x150LogoName), Square70x70LogoDirectoryPath, Square150x150LogoDirectoryPath);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Decompile(ManifestRTProcessingResult ProcessingResult)']/*"/>
        public static ManifestRTDecompilationResult Decompile(ManifestRTProcessingResult ProcessingResult)
        {
            return Decompiler.Decompile(ProcessingResult);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='Decompile(ManifestRTCompilationResult CompilationResult)']/*"/>
        public static ManifestRTDecompilationResult Decompile(ManifestRTCompilationResult CompilationResult)
        {
            return Decompiler.Decompile(CompilationResult);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='CanBeProcessed(string)']/*"/>
        public static bool CanBeProcessed(string Path)
        {
            return Processer.CanBeProcessed(Path);
        }
        /// <include file=".Docs/.ManifestRTService.xml" path="docs/method[@name='CanBeProcessed(string, string)']/*"/>
        public static bool CanBeProcessed(string AppDirectory, string AppName)
        {
            return Processer.CanBeProcessed(PathService.CombinePath(AppDirectory, NameBuilder.Build(AppName)));
        }
        #endregion
    }
}