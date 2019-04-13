using System;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestRTProcessingResult.xml" path="docs/header"/>
    [Serializable]
    public sealed class ManifestRTProcessingResult : ManifestRT
    {
        #region Constructors
        internal ManifestRTProcessingResult(IDictionary<ManifestRTComponentType, ManifestRTComponentData> Components)
            : base(Components)
        { }
        #endregion
    }
}