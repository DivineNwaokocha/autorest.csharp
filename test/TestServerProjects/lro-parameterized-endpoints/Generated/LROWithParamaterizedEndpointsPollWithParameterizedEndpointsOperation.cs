// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace lro_parameterized_endpoints
{
    /// <summary> Poll with method and client level parameters in endpoint. </summary>
    public partial class LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation : Operation<string>, IOperationSource<string>
    {
        private readonly ArmOperationHelpers<string> _operation;

        /// <summary> Initializes a new instance of LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation for mocking. </summary>
        protected LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation()
        {
        }

        internal LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<string>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "LROWithParamaterizedEndpointsPollWithParameterizedEndpointsOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override string Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<string>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<string>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        string IOperationSource<string>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return document.RootElement.GetString();
        }

        async ValueTask<string> IOperationSource<string>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return document.RootElement.GetString();
        }
    }
}
