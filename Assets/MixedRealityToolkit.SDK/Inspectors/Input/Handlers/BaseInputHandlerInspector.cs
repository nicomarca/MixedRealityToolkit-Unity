﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using MRTKPrefix.Editor.Utilities;
using UnityEditor;

namespace MRTKPrefix.Editor.Input
{
    public class BaseInputHandlerInspector : UnityEditor.Editor
    {
        private SerializedProperty isFocusRequiredProperty;

        protected virtual void OnEnable()
        {
            MixedRealityInspectorUtility.CheckMixedRealityConfigured(false);
            isFocusRequiredProperty = serializedObject.FindProperty("isFocusRequired");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.Space();
            EditorGUILayout.PropertyField(isFocusRequiredProperty);
            serializedObject.ApplyModifiedProperties();
        }
    }
}