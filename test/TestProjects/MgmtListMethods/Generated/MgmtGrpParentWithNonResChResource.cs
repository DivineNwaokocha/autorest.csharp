// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Management;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary>
    /// A Class representing a MgmtGrpParentWithNonResCh along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MgmtGrpParentWithNonResChResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMgmtGrpParentWithNonResChResource method.
    /// Otherwise you can get one from its parent resource <see cref="ManagementGroupResource" /> using the GetMgmtGrpParentWithNonResCh method.
    /// </summary>
    public partial class MgmtGrpParentWithNonResChResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MgmtGrpParentWithNonResChResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string groupId, string mgmtGrpParentWithNonResChName)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mgmtGrpParentWithNonResChClientDiagnostics;
        private readonly MgmtGrpParentWithNonResChesRestOperations _mgmtGrpParentWithNonResChRestClient;
        private readonly MgmtGrpParentWithNonResChData _data;

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChResource"/> class for mocking. </summary>
        protected MgmtGrpParentWithNonResChResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MgmtGrpParentWithNonResChResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MgmtGrpParentWithNonResChResource(ArmClient client, MgmtGrpParentWithNonResChData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MgmtGrpParentWithNonResChResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MgmtGrpParentWithNonResChResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mgmtGrpParentWithNonResChClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mgmtGrpParentWithNonResChApiVersion);
            _mgmtGrpParentWithNonResChRestClient = new MgmtGrpParentWithNonResChesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mgmtGrpParentWithNonResChApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Management/managementGroups/mgmtGrpParentWithNonResChes";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MgmtGrpParentWithNonResChData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// Operation Id: MgmtGrpParentWithNonResChes_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MgmtGrpParentWithNonResChResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.Get");
            scope.Start();
            try
            {
                var response = await _mgmtGrpParentWithNonResChRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResChResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// Operation Id: MgmtGrpParentWithNonResChes_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MgmtGrpParentWithNonResChResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.Get");
            scope.Start();
            try
            {
                var response = _mgmtGrpParentWithNonResChRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGrpParentWithNonResChResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}/nonResourceChild
        /// Operation Id: MgmtGrpParentWithNonResChes_ListNonResourceChild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NonResourceChild" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NonResourceChild> GetNonResourceChildAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NonResourceChild>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.GetNonResourceChild");
                scope.Start();
                try
                {
                    var response = await _mgmtGrpParentWithNonResChRestClient.ListNonResourceChildAsync(Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Lists all.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}/nonResourceChild
        /// Operation Id: MgmtGrpParentWithNonResChes_ListNonResourceChild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NonResourceChild" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NonResourceChild> GetNonResourceChild(CancellationToken cancellationToken = default)
        {
            Page<NonResourceChild> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.GetNonResourceChild");
                scope.Start();
                try
                {
                    var response = _mgmtGrpParentWithNonResChRestClient.ListNonResourceChild(Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// Operation Id: MgmtGrpParentWithNonResChes_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<MgmtGrpParentWithNonResChResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGrpParentWithNonResChRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResChResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// Operation Id: MgmtGrpParentWithNonResChes_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResChResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGrpParentWithNonResChRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGrpParentWithNonResChResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// Operation Id: MgmtGrpParentWithNonResChes_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<MgmtGrpParentWithNonResChResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.SetTags");
            scope.Start();
            try
            {
                await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGrpParentWithNonResChRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResChResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// Operation Id: MgmtGrpParentWithNonResChes_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResChResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.SetTags");
            scope.Start();
            try
            {
                GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGrpParentWithNonResChRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGrpParentWithNonResChResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// Operation Id: MgmtGrpParentWithNonResChes_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<MgmtGrpParentWithNonResChResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGrpParentWithNonResChRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGrpParentWithNonResChResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGrpParentWithNonResChes/{mgmtGrpParentWithNonResChName}
        /// Operation Id: MgmtGrpParentWithNonResChes_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<MgmtGrpParentWithNonResChResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _mgmtGrpParentWithNonResChClientDiagnostics.CreateScope("MgmtGrpParentWithNonResChResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = GetTagResource().Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGrpParentWithNonResChRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGrpParentWithNonResChResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
