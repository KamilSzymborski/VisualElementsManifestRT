using System;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestRT.xml" path="docs/header"/>
    [Serializable]
    public abstract class ManifestRT : Dictionary<ManifestRTComponentType, ManifestRTComponentData>
    {
        #region Constructors
        internal ManifestRT(IDictionary<ManifestRTComponentType, ManifestRTComponentData> Components) : base(Components) { }
        #endregion
    }
}