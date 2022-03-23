// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace SingletonResource
{
    /// <summary>
    /// A Class representing a Car along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="CarResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetCarResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetCar method.
    /// </summary>
    public partial class CarResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CarResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string carName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _carClientDiagnostics;
        private readonly CarsRestOperations _carRestClient;
        private readonly CarData _data;

        /// <summary> Initializes a new instance of the <see cref="CarResource"/> class for mocking. </summary>
        protected CarResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "CarResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CarResource(ArmClient client, CarData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CarResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CarResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _carClientDiagnostics = new ClientDiagnostics("SingletonResource", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string carApiVersion);
            _carRestClient = new CarsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, carApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Compute/cars";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CarData Data
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

        /// <summary> Gets an object representing a IgnitionResource along with the instance operations that can be performed on it in the Car. </summary>
        /// <returns> Returns a <see cref="IgnitionResource" /> object. </returns>
        public virtual IgnitionResource GetIgnition()
        {
            return new IgnitionResource(Client, new ResourceIdentifier(Id.ToString() + "/ignitions/default"));
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}
        /// Operation Id: Cars_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CarResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _carClientDiagnostics.CreateScope("CarResource.Get");
            scope.Start();
            try
            {
                var response = await _carRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CarResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/cars/{carName}
        /// Operation Id: Cars_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CarResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _carClientDiagnostics.CreateScope("CarResource.Get");
            scope.Start();
            try
            {
                var response = _carRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CarResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
