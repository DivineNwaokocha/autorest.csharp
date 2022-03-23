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

namespace MgmtParamOrdering
{
    /// <summary>
    /// A class representing a collection of <see cref="DedicatedHostResource" /> and their operations.
    /// Each <see cref="DedicatedHostResource" /> in the collection will belong to the same instance of <see cref="DedicatedHostGroupResource" />.
    /// To get a <see cref="DedicatedHostCollection" /> instance call the GetDedicatedHosts method from an instance of <see cref="DedicatedHostGroupResource" />.
    /// </summary>
    public partial class DedicatedHostCollection : ArmCollection, IEnumerable<DedicatedHostResource>, IAsyncEnumerable<DedicatedHostResource>
    {
        private readonly ClientDiagnostics _dedicatedHostClientDiagnostics;
        private readonly DedicatedHostsRestOperations _dedicatedHostRestClient;

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostCollection"/> class for mocking. </summary>
        protected DedicatedHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DedicatedHostCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dedicatedHostClientDiagnostics = new ClientDiagnostics("MgmtParamOrdering", DedicatedHostResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DedicatedHostResource.ResourceType, out string dedicatedHostApiVersion);
            _dedicatedHostRestClient = new DedicatedHostsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dedicatedHostApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DedicatedHostGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DedicatedHostGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a dedicated host .
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<DedicatedHostResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hostName, DedicatedHostData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dedicatedHostRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtParamOrderingArmOperation<DedicatedHostResource>(new DedicatedHostOperationSource(Client), _dedicatedHostClientDiagnostics, Pipeline, _dedicatedHostRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update a dedicated host .
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hostName"> The name of the dedicated host . </param>
        /// <param name="parameters"> Parameters supplied to the Create Dedicated Host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<DedicatedHostResource> CreateOrUpdate(WaitUntil waitUntil, string hostName, DedicatedHostData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dedicatedHostRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters, cancellationToken);
                var operation = new MgmtParamOrderingArmOperation<DedicatedHostResource>(new DedicatedHostOperationSource(Client), _dedicatedHostClientDiagnostics, Pipeline, _dedicatedHostRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about a dedicated host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual async Task<Response<DedicatedHostResource>> GetAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _dedicatedHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about a dedicated host.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<DedicatedHostResource> Get(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.Get");
            scope.Start();
            try
            {
                var response = _dedicatedHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DedicatedHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts
        /// Operation Id: DedicatedHosts_ListByHostGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DedicatedHostResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DedicatedHostResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DedicatedHostResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostRestClient.ListByHostGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DedicatedHostResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dedicatedHostRestClient.ListByHostGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all of the dedicated hosts in the specified dedicated host group. Use the nextLink property in the response to get the next page of dedicated hosts.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts
        /// Operation Id: DedicatedHosts_ListByHostGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DedicatedHostResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DedicatedHostResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DedicatedHostResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostRestClient.ListByHostGroup(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DedicatedHostResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dedicatedHostRestClient.ListByHostGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DedicatedHostResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(hostName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual async Task<Response<DedicatedHostResource>> GetIfExistsAsync(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dedicatedHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DedicatedHostResource>(null, response.GetRawResponse());
                return Response.FromValue(new DedicatedHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}/hosts/{hostName}
        /// Operation Id: DedicatedHosts_Get
        /// </summary>
        /// <param name="hostName"> The name of the dedicated host. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostName"/> is null. </exception>
        public virtual Response<DedicatedHostResource> GetIfExists(string hostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostName, nameof(hostName));

            using var scope = _dedicatedHostClientDiagnostics.CreateScope("DedicatedHostCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dedicatedHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, hostName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DedicatedHostResource>(null, response.GetRawResponse());
                return Response.FromValue(new DedicatedHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DedicatedHostResource> IEnumerable<DedicatedHostResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DedicatedHostResource> IAsyncEnumerable<DedicatedHostResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
