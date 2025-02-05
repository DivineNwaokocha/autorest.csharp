// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using body_string.Models;

namespace body_string
{
    /// <summary> The Enum service client. </summary>
    public partial class EnumClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal EnumRestClient RestClient { get; }

        /// <summary> Initializes a new instance of EnumClient for mocking. </summary>
        protected EnumClient()
        {
        }

        /// <summary> Initializes a new instance of EnumClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal EnumClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new EnumRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get enum value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Colors>> GetNotExpandableAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.GetNotExpandable");
            scope.Start();
            try
            {
                return await RestClient.GetNotExpandableAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get enum value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Colors> GetNotExpandable(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.GetNotExpandable");
            scope.Start();
            try
            {
                return RestClient.GetNotExpandable(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sends value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="stringBody"> string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutNotExpandableAsync(Colors stringBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.PutNotExpandable");
            scope.Start();
            try
            {
                return await RestClient.PutNotExpandableAsync(stringBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sends value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="stringBody"> string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutNotExpandable(Colors stringBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.PutNotExpandable");
            scope.Start();
            try
            {
                return RestClient.PutNotExpandable(stringBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get enum value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Colors>> GetReferencedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.GetReferenced");
            scope.Start();
            try
            {
                return await RestClient.GetReferencedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get enum value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Colors> GetReferenced(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.GetReferenced");
            scope.Start();
            try
            {
                return RestClient.GetReferenced(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sends value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="enumStringBody"> enum string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutReferencedAsync(Colors enumStringBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.PutReferenced");
            scope.Start();
            try
            {
                return await RestClient.PutReferencedAsync(enumStringBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sends value &apos;red color&apos; from enumeration of &apos;red color&apos;, &apos;green-color&apos;, &apos;blue_color&apos;. </summary>
        /// <param name="enumStringBody"> enum string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutReferenced(Colors enumStringBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.PutReferenced");
            scope.Start();
            try
            {
                return RestClient.PutReferenced(enumStringBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get value &apos;green-color&apos; from the constant. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RefColorConstant>> GetReferencedConstantAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.GetReferencedConstant");
            scope.Start();
            try
            {
                return await RestClient.GetReferencedConstantAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get value &apos;green-color&apos; from the constant. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RefColorConstant> GetReferencedConstant(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.GetReferencedConstant");
            scope.Start();
            try
            {
                return RestClient.GetReferencedConstant(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sends value &apos;green-color&apos; from a constant. </summary>
        /// <param name="enumStringBody"> enum string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutReferencedConstantAsync(RefColorConstant enumStringBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.PutReferencedConstant");
            scope.Start();
            try
            {
                return await RestClient.PutReferencedConstantAsync(enumStringBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sends value &apos;green-color&apos; from a constant. </summary>
        /// <param name="enumStringBody"> enum string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutReferencedConstant(RefColorConstant enumStringBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnumClient.PutReferencedConstant");
            scope.Start();
            try
            {
                return RestClient.PutReferencedConstant(enumStringBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
