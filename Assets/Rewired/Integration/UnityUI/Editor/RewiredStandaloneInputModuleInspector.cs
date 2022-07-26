﻿// Copyright (c) 2018 Augie R. Maddox, Guavaman Enterprises. All rights reserved.
#pragma warning disable 0219
#pragma warning disable 0618
#pragma warning disable 0649

namespace Rewired.Editor
{
    using Rewired.Integration.UnityUI;
    using UnityEditor;

    [System.ComponentModel.Browsable(false)]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    [CustomEditor(typeof(RewiredStandaloneInputModule))]
    public sealed class RewiredStandaloneInputModuleInspector : CustomInspector_External
    {

        private void OnEnable()
        {
            internalEditor = new RewiredStandaloneInputModuleInspector_Internal(this);
            internalEditor.OnEnable();
        }
    }
}