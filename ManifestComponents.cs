using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace KamilSzymborski.VisualElementsManifestRT
{
    /// <include file=".Docs/.ManifestComponents.xml" path="docs/header"/>
    [Serializable]
    public abstract class ManifestComponents : ReadOnlyDictionary<ManifestComponentType, ManifestComponentData>
    {
        #region Constructors
        internal ManifestComponents(IDictionary<ManifestComponentType, ManifestComponentData> Components) : base(Components) { }
        #endregion
    }
}