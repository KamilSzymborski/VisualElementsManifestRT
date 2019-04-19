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
            if (ManifestService.Validate(Manifest) == false) return false;

            
            var VisualElements = ManifestService.Parse(Manifest);
            // if is basic version (without images) - ok
            if (VisualElements.IsSquare70x70LogoAndSquare150x150LogoSet() == false) return true;

             
            var Square70x70LogoPath = PathService.DetermineFullPath(PathService.GetDirectoryPath(Path), VisualElements.GetSetSquare70x70Logo());
            var Square150x150LogoPath = PathService.DetermineFullPath(PathService.GetDirectoryPath(Path), VisualElements.GetSetSquare150x150Logo());
            // images exists for sure?
            return FileService.Exists(Square70x70LogoPath) && FileService.Exists(Square150x150LogoPath);
        }
        internal static ManifestRTProcessingResult Process(string Path)
        {
            var AppName = PathService.GetFileName(Path);
            var VisualElements = ManifestService.Parse(FileService.ReadAsString(Path));

            var Components = new Dictionary<ManifestRTComponentType, ManifestRTComponentData>
            {
                [ManifestRTComponentType.Manifest] = ProcessManifestData(VisualElements, AppName)
            };

            if (VisualElements.IsSquare70x70LogoAndSquare150x150LogoSet())
            {
                Components[ManifestRTComponentType.Square70x70Logo] = ProcessSquare70x70LogoData(VisualElements, Path);
                Components[ManifestRTComponentType.Square150x150Logo] = ProcessSquare150x150LogoData(VisualElements, Path);
            }

            return new ManifestRTProcessingResult(Components);
        }

        private static ManifestRTComponentData ProcessManifestData(VisualElements VisualElements, string AppName)
        {
            var Manifest = ManifestService.Create(VisualElements);

            var ManifestData = StringFormatter.Serialize(Manifest);
            var ManifestFileName = AppName;

            return new ManifestRTComponentData(ManifestData, ManifestFileName);
        }
        private static ManifestRTComponentData ProcessSquare70x70LogoData(VisualElements VisualElements, string Path)
        {
            var LogoPath = PathService.DetermineFullPath(PathService.GetDirectoryPath(Path), VisualElements.GetSetSquare70x70Logo());

            var LogoData = FileService.ReadAsBytes(LogoPath);
            var LogoFileName = VisualElements.GetSetSquare70x70Logo();

            return new ManifestRTComponentData(LogoData, LogoFileName);
        }
        private static ManifestRTComponentData ProcessSquare150x150LogoData(VisualElements VisualElements, string Path)
        {
            var LogoPath = PathService.DetermineFullPath(PathService.GetDirectoryPath(Path), VisualElements.GetSetSquare150x150Logo());

            var LogoData = FileService.ReadAsBytes(LogoPath);
            var LogoFileName = VisualElements.GetSetSquare150x150Logo();

            return new ManifestRTComponentData(LogoData, LogoFileName);
        }
        #endregion
    }
}