using System;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestRTComponentType.xml" path="docs/header"/>
    [Serializable]
    public enum ManifestRTComponentType
    {
        /// <include file=".Docs/.ManifestRTComponentType.xml" path="docs/value[@name='Manifest']/*"/>
        Manifest,
        /// <include file=".Docs/.ManifestRTComponentType.xml" path="docs/value[@name='Square70x70Logo']/*"/>
        Square70x70Logo,
        /// <include file=".Docs/.ManifestRTComponentType.xml" path="docs/value[@name='Square150x150Logo']/*"/>
        Square150x150Logo
    }
}