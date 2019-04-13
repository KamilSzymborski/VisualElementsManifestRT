using System;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestRTCompilationResult.xml" path="docs/header"/>
    [Serializable]
    public sealed class ManifestRTCompilationResult : ManifestRT
    {
        #region Constructors
        internal ManifestRTCompilationResult(IDictionary<ManifestRTComponentType, ManifestRTComponentData> Components)
            : base(Components)
        { }
        #endregion
    }
}