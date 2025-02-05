// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtRenameRules.Models
{
    /// <summary> The input for OrchestrationServiceState. </summary>
    public partial class OrchestrationServiceStateContent
    {
        /// <summary> Initializes a new instance of OrchestrationServiceStateContent. </summary>
        /// <param name="serviceName"> The name of the service. </param>
        /// <param name="action"> The action to be performed. </param>
        public OrchestrationServiceStateContent(OrchestrationServiceName serviceName, OrchestrationServiceStateAction action)
        {
            ServiceName = serviceName;
            Action = action;
        }

        /// <summary> The name of the service. </summary>
        public OrchestrationServiceName ServiceName { get; }
        /// <summary> The action to be performed. </summary>
        public OrchestrationServiceStateAction Action { get; }
    }
}
