using System;
using System.Collections.Generic;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestCompilationResult.xml" path="docs/header"/>
    [Serializable]
    public sealed class ManifestCompilationResult : ManifestComponents
    {
        #region Constructors
        internal ManifestCompilationResult(IDictionary<ManifestComponentType, ManifestComponentData> Components)
            : base(Components)
        { }
        #endregion
    }
}