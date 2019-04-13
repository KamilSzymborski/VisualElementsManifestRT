using System.Text;


namespace KamilSzymborski.VisualElementsManifestRT
{
    internal static class StringFormatter
    {
        #region Methods
        internal static byte[] Serialize(string Source)
        {
            return Encoding.UTF8.GetBytes(Source);
        }
        internal static string Deserialize(byte[] Source)
        {
            return Encoding.UTF8.GetString(Source);
        }
        #endregion
    }
}