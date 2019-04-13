using KamilSzymborski.VisualElementsManifest;
using KamilSzymborski.VisualElementsManifest.Extensions;

using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class Compiler
    {
        #region Methods
        internal static ManifestRTCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo)
        {
            var VisualElements = new VisualElements();
                VisualElements.SetBackgroundColorOn(BackgroundColor);
                VisualElements.SetForegroundTextOn(LightForegroundText);
                VisualElements.SetShowNameOnSquare150x150LogoOn(ShowNameOnSquare150x150Logo);
            var Manifest = ManifestService.Create(VisualElements);

            var ManifestData = StringFormatter.Serialize(Manifest);
            var ManifestFileName = NameBuilder.Build(AppName);

            var Components = new Dictionary<ManifestRTComponentType, ManifestRTComponentData>()
            {
                {ManifestRTComponentType.Manifest, new ManifestRTComponentData(ManifestData, ManifestFileName)}
            };

            return new ManifestRTCompilationResult(Components);
        }
        internal static ManifestRTCompilationResult Compile(string AppName, int BackgroundColor, bool LightForegroundText, bool ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, bool AutodetectFormat, string Square70x70LogoName, string Square150x150LogoName, string Square70x70LogoDirectoryPath, string Square150x150LogoDirectoryPath)
        {
            var Square70x70LogoFullName = AutodetectFormat ? PathService.CombineName(Square70x70LogoName, ImageService.GetKnownFormat(Square70x70LogoData)) : Square70x70LogoName;
            var Square150x150LogoFullName = AutodetectFormat ? PathService.CombineName(Square150x150LogoName, ImageService.GetKnownFormat(Square150x150LogoData)) : Square150x150LogoName;

            var Square70x70LogoPath = PathService.CombinePath(Square70x70LogoDirectoryPath, Square70x70LogoFullName);
            var Square150x150LogoPath = PathService.CombinePath(Square150x150LogoDirectoryPath, Square150x150LogoFullName);

            var VisualElements = new VisualElements();
                VisualElements.SetBackgroundColorOn(BackgroundColor);
                VisualElements.SetForegroundTextOn(LightForegroundText);
                VisualElements.SetShowNameOnSquare150x150LogoOn(ShowNameOnSquare150x150Logo);
                VisualElements.SetSquare70x70LogoOn(Square70x70LogoPath);
                VisualElements.SetSquare150x150LogoOn(Square150x150LogoPath);
            var Manifest = ManifestService.Create(VisualElements);

            var ManifestData = StringFormatter.Serialize(Manifest);
            var ManifestFileName = NameBuilder.Build(AppName);

            var Components = new Dictionary<ManifestRTComponentType, ManifestRTComponentData>()
            {
                {ManifestRTComponentType.Manifest, new ManifestRTComponentData(ManifestData, ManifestFileName)},
                {ManifestRTComponentType.Square70x70Logo, new ManifestRTComponentData(Square70x70LogoData, Square70x70LogoPath)},
                {ManifestRTComponentType.Square150x150Logo, new ManifestRTComponentData(Square150x150LogoData, Square150x150LogoPath)},
            };

            return new ManifestRTCompilationResult(Components);
        }
        #endregion
    }
}