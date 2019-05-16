namespace KamilSzymborski.VisualElementsManifestRT.Extensions
{
    /// <include file="Extensions/.Docs/.ManifestDecompilationResultExtension.xml" path="docs/header"/>
    public static class ManifestDecompilationResultExtension
    {
        #region Methods
        /// <include file="Extensions/.Docs/.ManifestDecompilationResultExtension.xml" path="docs/method[@name='ContainsImagesData()']/*"/>
        public static bool ContainsImagesData(this ManifestDecompilationResult DecompilationResult)
        {
            return DecompilationResult.Square70x70LogoData is null == false && DecompilationResult.Square150x150LogoData is null == false && DecompilationResult.Square70x70LogoName is null == false && DecompilationResult.Square150x150LogoName is null == false && DecompilationResult.Square70x70LogoDirectoryPath is null == false && DecompilationResult.Square150x150LogoDirectoryPath is null == false && DecompilationResult.Square70x70LogoFormat is null == false && DecompilationResult.Square150x150LogoFormat is null == false;
        }
        #endregion
    }
}