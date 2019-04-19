using System.IO;
using System.Text;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class FileService
    {
        #region Methods
        internal static bool Exists(string Path)
        {
            return File.Exists(Path);
        }
        internal static byte[] ReadAsBytes(string Path)
        {
            byte[] Data = null;

            using (var Stream = File.OpenRead(Path))
            {
                Data = new byte[(int)Stream.Length];
                Stream.Read(Data, 0, Data.Length);
            }

            return Data;
        }
        internal static string ReadAsString(string Path)
        {
            byte[] Data = null;

            using (var Stream = File.OpenRead(Path))
            {
                Data = new byte[(int)Stream.Length];
                Stream.Read(Data, 0, Data.Length);
            }

            return Encoding.UTF8.GetString(Data);
        }
        #endregion
    }
}