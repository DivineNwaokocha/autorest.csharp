// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A Class representing a SubResourceModel2 along with the instance operations that can be performed on it. </summary>
    public class SubResourceModel2 : SubResourceModel2Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "SubResourceModel2"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SubResourceModel2(ResourceOperationsBase options, SubResourceModel2Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the SubResourceModel2Data. </summary>
        public SubResourceModel2Data Data { get; private set; }
    }
}
