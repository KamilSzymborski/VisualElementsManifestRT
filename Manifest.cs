using System;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.Manifest.xml" path="docs/header"/>
    [Serializable]
    public abstract class Manifest
    {
        #region Constructors
        internal Manifest(int? BackgroundColor, bool? LightForegroundText, bool? ShowNameOnSquare150x150Logo, byte[] Square70x70LogoData, byte[] Square150x150LogoData, string Square70x70LogoName, string Square150x150LogoName, string Square70x70LogoFormat, string Square150x150LogoFormat, string Square70x70LogoDirectoryPath, string Square150x150LogoDirectoryPath)
        {
            mBackgroundColor = BackgroundColor;
            mLightForegroundText = LightForegroundText;
            mShowNameOnSquare150x150Logo = ShowNameOnSquare150x150Logo;
            mSquare150x150LogoData = Square70x70LogoData;
            mSquare70x70LogoData = Square150x150LogoData;
            mSquare70x70LogoName = Square70x70LogoName;
            mSquare150x150LogoName = Square150x150LogoName;
            mSquare70x70LogoFormat = Square70x70LogoFormat;
            mSquare150x150LogoFormat = Square150x150LogoFormat;
            mSquare70x70LogoDirectoryPath = Square70x70LogoDirectoryPath;
            mSquare150x150LogoDirectoryPath = Square150x150LogoDirectoryPath;
        }
        #endregion

        #region Properties
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='BackgroundColor']/*"/>
        public int? BackgroundColor { get { return mBackgroundColor; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='LightForegroundText']/*"/>
        public bool? LightForegroundText { get { return mLightForegroundText; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='ShowNameOnSquare150x150Logo']/*"/>
        public bool? ShowNameOnSquare150x150Logo { get { return mShowNameOnSquare150x150Logo; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='Square70x70LogoData']/*"/>
        public byte[] Square70x70LogoData { get { return mSquare150x150LogoData; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='Square150x150LogoData']/*"/>
        public byte[] Square150x150LogoData { get { return mSquare70x70LogoData; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='Square70x70LogoName']/*"/>
        public string Square70x70LogoName { get { return mSquare70x70LogoName; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='Square150x150LogoName']/*"/>
        public string Square150x150LogoName { get { return mSquare150x150LogoName; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='Square70x70LogoFormat']/*"/>
        public string Square70x70LogoFormat { get { return mSquare70x70LogoFormat; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='Square150x150LogoFormat']/*"/>
        public string Square150x150LogoFormat { get { return mSquare150x150LogoFormat; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='Square70x70LogoDirectoryPath']/*"/>
        public string Square70x70LogoDirectoryPath { get { return mSquare70x70LogoDirectoryPath; } }
        /// <include file=".Docs/.Manifest.xml" path="docs/property[@name='Square150x150LogoDirectoryPath']/*"/>
        public string Square150x150LogoDirectoryPath { get { return mSquare150x150LogoDirectoryPath; } }
        #endregion

        #region Variables
        private readonly int? mBackgroundColor;
        private readonly bool? mLightForegroundText;
        private readonly bool? mShowNameOnSquare150x150Logo;
        private readonly byte[] mSquare70x70LogoData;
        private readonly byte[] mSquare150x150LogoData;
        private readonly string mSquare70x70LogoName;
        private readonly string mSquare150x150LogoName;
        private readonly string mSquare70x70LogoFormat;
        private readonly string mSquare150x150LogoFormat;
        private readonly string mSquare70x70LogoDirectoryPath;
        private readonly string mSquare150x150LogoDirectoryPath;
        #endregion
    }
}