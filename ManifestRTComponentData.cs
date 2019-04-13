using System;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestRTComponentData.xml" path="docs/header"/>
    [Serializable]
    public sealed class ManifestRTComponentData
    {
        #region Constructors
        internal ManifestRTComponentData(byte[] Data, string FileName)
        {
            mData = Data;
            mFileName = FileName;
        }
        #endregion

        #region Properties
        /// <include file=".Docs/.ManifestRTComponentData.xml" path="docs/property[@name='Data']/*"/>
        public byte[] Data { get { return mData; } }
        /// <include file=".Docs/.ManifestRTComponentData.xml" path="docs/property[@name='FileName']/*"/>
        public string FileName { get { return mFileName; } }
        #endregion

        #region Variables
        private readonly byte[] mData;
        private readonly string mFileName;
        #endregion
    }
}