using System.Linq;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class ImageService
    {
        #region Methods
        internal static string GetFormat(byte[] Data)
        {
            return HEADERS.Single(Header => Data.Take(Header.Value.Length).SequenceEqual(Header.Value)).Key;
        }
        #endregion

        #region Variables
        private static readonly Dictionary<string, byte[]> HEADERS = new Dictionary<string, byte[]>()
        {
            {"png", new byte[] { 0x89, 0x50, 0x4E, 0x47} },
            {"jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 } },
            {"gif", new byte[] { 0x47, 0x49, 0x46, 0x38 } }
        };
        #endregion
    }
}