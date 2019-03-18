﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.


namespace MRTKPrefix.Tests.Services
{
    internal interface ITestService : IMixedRealityService
    {
        bool IsEnabled { get; }
    }
}