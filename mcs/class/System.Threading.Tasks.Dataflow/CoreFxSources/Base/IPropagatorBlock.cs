﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

// =+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+
//
// IPropagatorBlock.cs
//
//
// The base interface for all propagator blocks.
//
// =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

namespace System.Threading.Tasks.Dataflow
{
    /// <summary>Represents a dataflow block that is both a target for data and a source of data.</summary>
    /// <typeparam name="TInput">Specifies the type of data accepted by the <see cref="IPropagatorBlock{TInput,TOutput}"/>.</typeparam>
    /// <typeparam name="TOutput">Specifies the type of data supplied by the <see cref="IPropagatorBlock{TInput,TOutput}"/>.</typeparam>
    public interface IPropagatorBlock<in TInput, out TOutput> : ITargetBlock<TInput>, ISourceBlock<TOutput>
    {
        // No additional members beyond those inherited from ITargetBlock<TInput> and ISourceBlock<TOutput>
    }
}
