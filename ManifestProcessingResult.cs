using System;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestProcessingResult.xml" path="docs/header"/>
    [Serializable]
    public sealed class ManifestProcessingResult : ManifestComponents
    {
        #region Constructors
        internal ManifestProcessingResult(IDictionary<ManifestComponentType, ManifestComponentData> Components)
            : base(Components)
        { }
        #endregion
    }
}