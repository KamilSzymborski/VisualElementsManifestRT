using KamilSzymborski.VisualElementsManifest;
using KamilSzymborski.VisualElementsManifest.Extensions;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class Decompiler
    {
        #region Methods
        internal static ManifestDecompilationResult Decompile(ManifestComponents Components)
        {
            var VisualElements = VisualElementsManifest.ManifestService.Parse(StringFormatter.Deserialize(Components[ManifestComponentType.Manifest].Data));

            var AppName = Components[ManifestComponentType.Manifest].FileName.Split('.')[0];
            var BackgroundColor = VisualElements.GetSetBackgroundColor();
            var LightForegroundText = VisualElements.IsForegroundTextSetOnLight();
            var ShowNameOnSquare150x150Logo = VisualElements.IsShowNameOnSquare150x150LogoSetOnOn();
            var Square70x70LogoData = Components.ContainsKey(ManifestComponentType.Square70x70Logo) ? Components[ManifestComponentType.Square70x70Logo].Data : null;
            var Square150x150LogoData = Components.ContainsKey(ManifestComponentType.Square150x150Logo) ? Components[ManifestComponentType.Square150x150Logo].Data : null;
            var Square70x70LogoName = Components.ContainsKey(ManifestComponentType.Square70x70Logo) ? PathService.GetShortName(Components[ManifestComponentType.Square70x70Logo].FileName) : null;
            var Square150x150LogoName = Components.ContainsKey(ManifestComponentType.Square150x150Logo) ? PathService.GetShortName(Components[ManifestComponentType.Square150x150Logo].FileName) : null;
            var Square70x70LogoFormat = Components.ContainsKey(ManifestComponentType.Square70x70Logo) ? PathService.GetFileExtension(Components[ManifestComponentType.Square70x70Logo].FileName) : null;
            var Square150x150LogoFormat = Components.ContainsKey(ManifestComponentType.Square150x150Logo) ? PathService.GetFileExtension(Components[ManifestComponentType.Square150x150Logo].FileName) : null;
            var Square70x70LogoDirectoryPath = Components.ContainsKey(ManifestComponentType.Square70x70Logo) ? PathService.GetDirectoryPath(Components[ManifestComponentType.Square70x70Logo].FileName) : null;
            var Square150x150LogoDirectoryPath = Components.ContainsKey(ManifestComponentType.Square150x150Logo) ? PathService.GetDirectoryPath(Components[ManifestComponentType.Square150x150Logo].FileName) : null;

            return new ManifestDecompilationResult(AppName, BackgroundColor, LightForegroundText, ShowNameOnSquare150x150Logo, Square70x70LogoData, Square150x150LogoData, Square70x70LogoName, Square150x150LogoName, Square70x70LogoFormat, Square150x150LogoFormat, Square70x70LogoDirectoryPath, Square150x150LogoDirectoryPath);
        }
        #endregion
    }
}