﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using Microsoft.Rest;

namespace ConsoleApplication1
{
    public partial interface IValues
    {
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<string>>> GetWithOperationResponseAsync(CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='dateTimeOffset'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PostRawDateWithOperationResponseAsync(DateTimeOffset dateTimeOffset, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        
        /// <param name='wrapper'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        Task<HttpOperationResponse<string>> PostWrappedRawDateWithOperationResponseAsync(OffsetWrapper wrapper, CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}