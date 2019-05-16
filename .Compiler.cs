using KamilSzymborski.VisualElementsManifest;
using KamilSzymborski.VisualElementsManifest.Tools;
using KamilSzymborski.VisualElementsManifest.Extensions;

using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class Compiler
    {
        #region Methods
        internal static ManifestCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo)
        {
            var VisualElements = new VisualElements();
                VisualElements.SetBackgroundColorOn(BackgroundColor);
                VisualElements.SetForegroundTextOn(LightForegroundText);
                VisualElements.SetShowNameOnSquare150x150LogoOn(ShowNameOnSquare150x150Logo);
            var Manifest = VisualElementsManifest.ManifestService.Create(VisualElements);

            var ManifestData = StringFormatter.Serialize(Manifest);
            var ManifestFileName = ManifestNameBuilder.Build(AppName);

            var Components = new Dictionary<ManifestComponentType, ManifestComponentData>()
            {
                {ManifestComponentType.Manifest, new ManifestComponentData(ManifestData, ManifestFileName)}
            };

            return new ManifestCompilationResult(Components);
        }
        internal static ManifestCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, string Square70x70LogoName, string Square150x150LogoName, string OptionalSquare70x70LogoFormat = null, string OptionalSquare150x150LogoFormat = null, string OptionalSquare70x70LogoDirectoryPath = null, string OptionalSquare150x150LogoDirectoryPath = null)
        {
            var Square70x70LogoFormat = OptionalSquare70x70LogoFormat ?? ImageService.GetFormat(Square70x70LogoData);
            var Square150x150LogoFormat = OptionalSquare150x150LogoFormat ?? ImageService.GetFormat(Square150x150LogoData);

            var Square70x70LogoDirectoryPath = OptionalSquare70x70LogoDirectoryPath ?? string.Empty;
            var Square150x150LogoDirectoryPath = OptionalSquare150x150LogoDirectoryPath ?? string.Empty;

            var Square70x70LogoFullName = PathService.CombineName(Square70x70LogoName, Square70x70LogoFormat);
            var Square150x150LogoFullName = PathService.CombineName(Square150x150LogoName, Square150x150LogoFormat);

            var Square70x70LogoPath = PathService.CombinePath(Square70x70LogoDirectoryPath, Square70x70LogoFullName);
            var Square150x150LogoPath = PathService.CombinePath(Square150x150LogoDirectoryPath, Square150x150LogoFullName);

            var VisualElements = new VisualElements();
                VisualElements.SetBackgroundColorOn(BackgroundColor);
                VisualElements.SetForegroundTextOn(LightForegroundText);
                VisualElements.SetShowNameOnSquare150x150LogoOn(ShowNameOnSquare150x150Logo);
                VisualElements.SetSquare70x70LogoOn(Square70x70LogoPath);
                VisualElements.SetSquare150x150LogoOn(Square150x150LogoPath);
            var Manifest = VisualElementsManifest.ManifestService.Create(VisualElements);

            var ManifestData = StringFormatter.Serialize(Manifest);
            var ManifestFileName = ManifestNameBuilder.Build(AppName);

            var Components = new Dictionary<ManifestComponentType, ManifestComponentData>()
            {
                {ManifestComponentType.Manifest, new ManifestComponentData(ManifestData, ManifestFileName)},
                {ManifestComponentType.Square70x70Logo, new ManifestComponentData(Square70x70LogoData, Square70x70LogoPath)},
                {ManifestComponentType.Square150x150Logo, new ManifestComponentData(Square150x150LogoData, Square150x150LogoPath)},
            };
            
            return new ManifestCompilationResult(Components);
        }
        #endregion
    }
}