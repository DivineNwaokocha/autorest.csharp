// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace body_string
{
    /// <summary> The String service client. </summary>
    public partial class StringClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal StringRestClient RestClient { get; }

        /// <summary> Initializes a new instance of StringClient for mocking. </summary>
        protected StringClient()
        {
        }

        /// <summary> Initializes a new instance of StringClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal StringClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new StringRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get null string value value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> GetNullAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetNull");
            scope.Start();
            try
            {
                return await RestClient.GetNullAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null string value value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> GetNull(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetNull");
            scope.Start();
            try
            {
                return RestClient.GetNull(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set string value null. </summary>
        /// <param name="stringBody"> string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutNullAsync(string stringBody = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutNull");
            scope.Start();
            try
            {
                return await RestClient.PutNullAsync(stringBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set string value null. </summary>
        /// <param name="stringBody"> string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutNull(string stringBody = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutNull");
            scope.Start();
            try
            {
                return RestClient.PutNull(stringBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get empty string value value &apos;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> GetEmptyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetEmpty");
            scope.Start();
            try
            {
                return await RestClient.GetEmptyAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get empty string value value &apos;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> GetEmpty(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetEmpty");
            scope.Start();
            try
            {
                return RestClient.GetEmpty(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set string value empty &apos;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutEmptyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutEmpty");
            scope.Start();
            try
            {
                return await RestClient.PutEmptyAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set string value empty &apos;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutEmpty(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutEmpty");
            scope.Start();
            try
            {
                return RestClient.PutEmpty(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get mbcs string value &apos;啊齄丂狛狜隣郎隣兀﨩ˊ〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> GetMbcsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetMbcs");
            scope.Start();
            try
            {
                return await RestClient.GetMbcsAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get mbcs string value &apos;啊齄丂狛狜隣郎隣兀﨩ˊ〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> GetMbcs(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetMbcs");
            scope.Start();
            try
            {
                return RestClient.GetMbcs(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set string value mbcs &apos;啊齄丂狛狜隣郎隣兀﨩ˊ〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutMbcsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutMbcs");
            scope.Start();
            try
            {
                return await RestClient.PutMbcsAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set string value mbcs &apos;啊齄丂狛狜隣郎隣兀﨩ˊ〞〡￤℡㈱‐ー﹡﹢﹫、〓ⅰⅹ⒈€㈠㈩ⅠⅫ！￣ぁんァヶΑ︴АЯаяāɡㄅㄩ─╋︵﹄︻︱︳︴ⅰⅹɑɡ〇〾⿻⺁䜣€&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutMbcs(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutMbcs");
            scope.Start();
            try
            {
                return RestClient.PutMbcs(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get string value with leading and trailing whitespace &apos;&lt;tab&gt;&lt;space&gt;&lt;space&gt;Now is the time for all good men to come to the aid of their country&lt;tab&gt;&lt;space&gt;&lt;space&gt;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> GetWhitespaceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetWhitespace");
            scope.Start();
            try
            {
                return await RestClient.GetWhitespaceAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get string value with leading and trailing whitespace &apos;&lt;tab&gt;&lt;space&gt;&lt;space&gt;Now is the time for all good men to come to the aid of their country&lt;tab&gt;&lt;space&gt;&lt;space&gt;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> GetWhitespace(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetWhitespace");
            scope.Start();
            try
            {
                return RestClient.GetWhitespace(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set String value with leading and trailing whitespace &apos;&lt;tab&gt;&lt;space&gt;&lt;space&gt;Now is the time for all good men to come to the aid of their country&lt;tab&gt;&lt;space&gt;&lt;space&gt;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutWhitespaceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutWhitespace");
            scope.Start();
            try
            {
                return await RestClient.PutWhitespaceAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Set String value with leading and trailing whitespace &apos;&lt;tab&gt;&lt;space&gt;&lt;space&gt;Now is the time for all good men to come to the aid of their country&lt;tab&gt;&lt;space&gt;&lt;space&gt;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutWhitespace(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutWhitespace");
            scope.Start();
            try
            {
                return RestClient.PutWhitespace(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get String value when no string value is sent in response payload. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<string>> GetNotProvidedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetNotProvided");
            scope.Start();
            try
            {
                return await RestClient.GetNotProvidedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get String value when no string value is sent in response payload. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> GetNotProvided(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetNotProvided");
            scope.Start();
            try
            {
                return RestClient.GetNotProvided(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get value that is base64 encoded. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<byte[]>> GetBase64EncodedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetBase64Encoded");
            scope.Start();
            try
            {
                return await RestClient.GetBase64EncodedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get value that is base64 encoded. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<byte[]> GetBase64Encoded(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetBase64Encoded");
            scope.Start();
            try
            {
                return RestClient.GetBase64Encoded(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get value that is base64url encoded. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<byte[]>> GetBase64UrlEncodedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetBase64UrlEncoded");
            scope.Start();
            try
            {
                return await RestClient.GetBase64UrlEncodedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get value that is base64url encoded. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<byte[]> GetBase64UrlEncoded(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetBase64UrlEncoded");
            scope.Start();
            try
            {
                return RestClient.GetBase64UrlEncoded(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put value that is base64url encoded. </summary>
        /// <param name="stringBody"> string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PutBase64UrlEncodedAsync(byte[] stringBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutBase64UrlEncoded");
            scope.Start();
            try
            {
                return await RestClient.PutBase64UrlEncodedAsync(stringBody, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Put value that is base64url encoded. </summary>
        /// <param name="stringBody"> string body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PutBase64UrlEncoded(byte[] stringBody, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.PutBase64UrlEncoded");
            scope.Start();
            try
            {
                return RestClient.PutBase64UrlEncoded(stringBody, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null value that is expected to be base64url encoded. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<byte[]>> GetNullBase64UrlEncodedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetNullBase64UrlEncoded");
            scope.Start();
            try
            {
                return await RestClient.GetNullBase64UrlEncodedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null value that is expected to be base64url encoded. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<byte[]> GetNullBase64UrlEncoded(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("StringClient.GetNullBase64UrlEncoded");
            scope.Start();
            try
            {
                return RestClient.GetNullBase64UrlEncoded(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
