// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtListMethods
{
    /// <summary>
    /// A class representing a collection of <see cref="ResGrpParentResource" /> and their operations.
    /// Each <see cref="ResGrpParentResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ResGrpParentCollection" /> instance call the GetResGrpParents method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ResGrpParentCollection : ArmCollection, IEnumerable<ResGrpParentResource>, IAsyncEnumerable<ResGrpParentResource>
    {
        private readonly ClientDiagnostics _resGrpParentClientDiagnostics;
        private readonly ResGrpParentsRestOperations _resGrpParentRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentCollection"/> class for mocking. </summary>
        protected ResGrpParentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResGrpParentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resGrpParentClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResGrpParentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResGrpParentResource.ResourceType, out string resGrpParentApiVersion);
            _resGrpParentRestClient = new ResGrpParentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resGrpParentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resGrpParentName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<ResGrpParentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resGrpParentName, ResGrpParentData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentName, nameof(resGrpParentName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resGrpParentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<ResGrpParentResource>(Response.FromValue(new ResGrpParentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resGrpParentName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ResGrpParentResource> CreateOrUpdate(WaitUntil waitUntil, string resGrpParentName, ResGrpParentData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentName, nameof(resGrpParentName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resGrpParentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentName, parameters, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<ResGrpParentResource>(Response.FromValue(new ResGrpParentResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="resGrpParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentName"/> is null. </exception>
        public virtual async Task<Response<ResGrpParentResource>> GetAsync(string resGrpParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentName, nameof(resGrpParentName));

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.Get");
            scope.Start();
            try
            {
                var response = await _resGrpParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="resGrpParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentName"/> is null. </exception>
        public virtual Response<ResGrpParentResource> Get(string resGrpParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentName, nameof(resGrpParentName));

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.Get");
            scope.Start();
            try
            {
                var response = _resGrpParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents
        /// Operation Id: ResGrpParents_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResGrpParentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResGrpParentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ResGrpParentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _resGrpParentRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResGrpParentResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents
        /// Operation Id: ResGrpParents_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResGrpParentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResGrpParentResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ResGrpParentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _resGrpParentRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResGrpParentResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="resGrpParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resGrpParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentName, nameof(resGrpParentName));

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resGrpParentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="resGrpParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentName"/> is null. </exception>
        public virtual Response<bool> Exists(string resGrpParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentName, nameof(resGrpParentName));

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resGrpParentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="resGrpParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentName"/> is null. </exception>
        public virtual async Task<Response<ResGrpParentResource>> GetIfExistsAsync(string resGrpParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentName, nameof(resGrpParentName));

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _resGrpParentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ResGrpParentResource>(null, response.GetRawResponse());
                return Response.FromValue(new ResGrpParentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParents/{resGrpParentName}
        /// Operation Id: ResGrpParents_Get
        /// </summary>
        /// <param name="resGrpParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resGrpParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resGrpParentName"/> is null. </exception>
        public virtual Response<ResGrpParentResource> GetIfExists(string resGrpParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resGrpParentName, nameof(resGrpParentName));

            using var scope = _resGrpParentClientDiagnostics.CreateScope("ResGrpParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resGrpParentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resGrpParentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ResGrpParentResource>(null, response.GetRawResponse());
                return Response.FromValue(new ResGrpParentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResGrpParentResource> IEnumerable<ResGrpParentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResGrpParentResource> IAsyncEnumerable<ResGrpParentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
