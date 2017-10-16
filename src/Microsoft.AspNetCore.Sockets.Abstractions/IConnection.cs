﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;

namespace Microsoft.AspNetCore.Sockets.Client
{
    public interface IConnection
    {
        Task StartAsync(CancellationToken cancellationToken = default);
        Task SendAsync(byte[] data, CancellationToken cancellationToken = default);
        Task DisposeAsync(CancellationToken cancellationToken = default);

        event Func<byte[], Task> Received;
        event Func<Exception, Task> Closed;

        IFeatureCollection Features { get; }
    }
}
