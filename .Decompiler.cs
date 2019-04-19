using KamilSzymborski.VisualElementsManifest;
using KamilSzymborski.VisualElementsManifest.Extensions;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class Decompiler
    {
        #region Methods
        internal static (int? BackgroundColor, bool? LightForegroundText, bool? ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, string Square70x70LogoName, string Square150x150LogoName, string Square70x70LogoFormat, string Square150x150LogoFormat, string Square70x70LogoDirectoryPath, string Square150x150LogoDirectoryPath) Decompile(ManifestRT ManifestRT)
        {
            var VisualElements = ManifestRT.ContainsKey(ManifestRTComponentType.Manifest) ? ManifestService.Parse(StringFormatter.Deserialize(ManifestRT[ManifestRTComponentType.Manifest].Data)) : null;

            var BackgroundColor = VisualElements?.GetSetBackgroundColor();
            var LightForegroundText = VisualElements?.IsForegroundTextSetOnLight();
            var ShowNameOnSquare150x150Logo = VisualElements?.IsShowNameOnSquare150x150LogoSetOnOn();
            var Square70x70LogoData = ManifestRT[ManifestRTComponentType.Square70x70Logo]?.Data;
            var Square150x150LogoData = ManifestRT[ManifestRTComponentType.Square150x150Logo]?.Data;
            var Square70x70LogoName = ManifestRT.ContainsKey(ManifestRTComponentType.Square70x70Logo) ? PathService.GetShortName(ManifestRT[ManifestRTComponentType.Square70x70Logo].FileName) : null;
            var Square150x150LogoName = ManifestRT.ContainsKey(ManifestRTComponentType.Square150x150Logo) ? PathService.GetShortName(ManifestRT[ManifestRTComponentType.Square150x150Logo].FileName) : null;
            var Square70x70LogoFormat = ManifestRT.ContainsKey(ManifestRTComponentType.Square70x70Logo) ? PathService.GetFileExtension(ManifestRT[ManifestRTComponentType.Square70x70Logo].FileName) : null;
            var Square150x150LogoFormat = ManifestRT.ContainsKey(ManifestRTComponentType.Square150x150Logo) ? PathService.GetFileExtension(ManifestRT[ManifestRTComponentType.Square150x150Logo].FileName) : null;
            var Square70x70LogoDirectoryPath = ManifestRT.ContainsKey(ManifestRTComponentType.Square70x70Logo) ? PathService.GetDirectoryPath(ManifestRT[ManifestRTComponentType.Square70x70Logo].FileName) : null;
            var Square150x150LogoDirectoryPath = ManifestRT.ContainsKey(ManifestRTComponentType.Square150x150Logo) ? PathService.GetDirectoryPath(ManifestRT[ManifestRTComponentType.Square150x150Logo].FileName) : null;

            return (BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo, Square70x70LogoData, Square150x150LogoData, Square70x70LogoName, Square150x150LogoName, Square70x70LogoFormat, Square150x150LogoFormat, Square70x70LogoDirectoryPath, Square150x150LogoDirectoryPath);
        }
        #endregion
    }
}