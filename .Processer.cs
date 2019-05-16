using KamilSzymborski.VisualElementsManifest;
using KamilSzymborski.VisualElementsManifest.Extensions;

using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class Processer
    {
        #region Methods
        internal static bool CanBeProcessed(string Path)
        {
            var Manifest = FileService.ReadAsString(Path);
            // if is not valid - stop
            if (VisualElementsManifest.ManifestService.Validate(Manifest) == false) return false;


            var VisualElements = VisualElementsManifest.ManifestService.Parse(Manifest);
            // if is basic version (without images) - ok
            if (VisualElements.IsSquare70x70LogoAndSquare150x150LogoSet() == false) return true;


            var Square70x70LogoPath = PathService.CombinePath(PathService.GetDirectoryPath(Path), VisualElements.GetSetSquare70x70Logo());
            var Square150x150LogoPath = PathService.CombinePath(PathService.GetDirectoryPath(Path), VisualElements.GetSetSquare150x150Logo());
            // images exists for sure?
            return FileService.Exists(Square70x70LogoPath) && FileService.Exists(Square150x150LogoPath);
        }
        internal static ManifestProcessingResult Process(string Path)
        {
            var Manifest = FileService.ReadAsString(Path);
            var VisualElements = VisualElementsManifest.ManifestService.Parse(Manifest);

            var ManifestData = StringFormatter.Serialize(Manifest);
            var ManifestFileName = PathService.GetFileName(Path);

            var Components = new Dictionary<ManifestComponentType, ManifestComponentData>
            {
                [ManifestComponentType.Manifest] = new ManifestComponentData(ManifestData, ManifestFileName)
            };

            if (VisualElements.IsSquare70x70LogoAndSquare150x150LogoSet())
            {
                var Square70x70LogoPath = PathService.CombinePath(PathService.GetDirectoryPath(Path), VisualElements.GetSetSquare70x70Logo());
                var Square150x150LogoPath = PathService.CombinePath(PathService.GetDirectoryPath(Path), VisualElements.GetSetSquare150x150Logo());

                var Square70x70LogoData = FileService.ReadAsBytes(Square70x70LogoPath);
                var Square150x150LogoData = FileService.ReadAsBytes(Square150x150LogoPath);
                var Square70x70LogoFileName = VisualElements.GetSetSquare70x70Logo();
                var Square150x150LogoFileName = VisualElements.GetSetSquare150x150Logo();

                Components[ManifestComponentType.Square70x70Logo] = new ManifestComponentData(Square70x70LogoData, Square70x70LogoFileName);
                Components[ManifestComponentType.Square150x150Logo] = new ManifestComponentData(Square150x150LogoData, Square150x150LogoFileName);
            }

            return new ManifestProcessingResult(Components);
        }
        #endregion
    }
}