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
using Azure.ResourceManager.Core;
using SupersetFlattenInheritance.Models;

namespace SupersetFlattenInheritance
{
    internal partial class WritableSubResourceModel1SRestOperations
    {
        private readonly string _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of WritableSubResourceModel1SRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public WritableSubResourceModel1SRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-10";
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Azure.ResourceManager.Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/writableSubResourceModel1s", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <param name="subscriptionId"> The String to use. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<WritableSubResourceModel1ListResult>> ListAsync(string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WritableSubResourceModel1ListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WritableSubResourceModel1ListResult.DeserializeWritableSubResourceModel1ListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="subscriptionId"> The String to use. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<WritableSubResourceModel1ListResult> List(string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WritableSubResourceModel1ListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WritableSubResourceModel1ListResult.DeserializeWritableSubResourceModel1ListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreatePutRequest(string subscriptionId, string resourceGroupName, string writableSubResourceModel1SName, WritableSubResourceModel1 parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/writableSubResourceModel1s/", false);
            uri.AppendPath(writableSubResourceModel1SName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <param name="subscriptionId"> The String to use. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="writableSubResourceModel1SName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<WritableSubResourceModel1>> PutAsync(string subscriptionId, string resourceGroupName, string writableSubResourceModel1SName, WritableSubResourceModel1 parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (writableSubResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreatePutRequest(subscriptionId, resourceGroupName, writableSubResourceModel1SName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WritableSubResourceModel1 value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WritableSubResourceModel1.DeserializeWritableSubResourceModel1(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="subscriptionId"> The String to use. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The WritableSubResourceModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="writableSubResourceModel1SName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response<WritableSubResourceModel1> Put(string subscriptionId, string resourceGroupName, string writableSubResourceModel1SName, WritableSubResourceModel1 parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (writableSubResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreatePutRequest(subscriptionId, resourceGroupName, writableSubResourceModel1SName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WritableSubResourceModel1 value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WritableSubResourceModel1.DeserializeWritableSubResourceModel1(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string writableSubResourceModel1SName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/writableSubResourceModel1s/", false);
            uri.AppendPath(writableSubResourceModel1SName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <param name="subscriptionId"> The String to use. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="writableSubResourceModel1SName"/> is null. </exception>
        public async Task<Response<WritableSubResourceModel1>> GetAsync(string subscriptionId, string resourceGroupName, string writableSubResourceModel1SName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (writableSubResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, writableSubResourceModel1SName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WritableSubResourceModel1 value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WritableSubResourceModel1.DeserializeWritableSubResourceModel1(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <param name="subscriptionId"> The String to use. </param>
        /// <param name="resourceGroupName"> The String to use. </param>
        /// <param name="writableSubResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="writableSubResourceModel1SName"/> is null. </exception>
        public Response<WritableSubResourceModel1> Get(string subscriptionId, string resourceGroupName, string writableSubResourceModel1SName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (writableSubResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(writableSubResourceModel1SName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, writableSubResourceModel1SName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WritableSubResourceModel1 value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WritableSubResourceModel1.DeserializeWritableSubResourceModel1(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
