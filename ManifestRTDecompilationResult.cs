using System;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestRTDecompilationResult.xml" path="docs/header"/>
    [Serializable]
    public sealed class ManifestRTDecompilationResult : Manifest
    {
        #region Constructors
        internal ManifestRTDecompilationResult(int? BackgroundColor, bool? LightForegroundText, bool? ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, string Square70x70LogoName, string Square150x150LogoName, string Square70x70LogoFormat, string Square150x150LogoFormat, string Square70x70LogoDirectoryPath, string Square150x150LogoDirectoryPath) 
            : base(BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo, Square70x70LogoData, Square150x150LogoData, Square70x70LogoName, Square150x150LogoName, Square70x70LogoFormat, Square150x150LogoFormat, Square70x70LogoDirectoryPath, Square150x150LogoDirectoryPath)
        { }
        #endregion
    }
}