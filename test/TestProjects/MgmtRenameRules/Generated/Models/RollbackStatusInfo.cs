// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtRenameRules.Models
{
    /// <summary> Information about rollback on failed VM instances after a OS Upgrade operation. </summary>
    public partial class RollbackStatusInfo
    {
        /// <summary> Initializes a new instance of RollbackStatusInfo. </summary>
        internal RollbackStatusInfo()
        {
        }

        /// <summary> Initializes a new instance of RollbackStatusInfo. </summary>
        /// <param name="successfullyRolledbackInstanceCount"> The number of instances which have been successfully rolled back. </param>
        /// <param name="failedRolledbackInstanceCount"> The number of instances which failed to rollback. </param>
        /// <param name="rollbackError"> Error details if OS rollback failed. </param>
        internal RollbackStatusInfo(int? successfullyRolledbackInstanceCount, int? failedRolledbackInstanceCount, ApiError rollbackError)
        {
            SuccessfullyRolledbackInstanceCount = successfullyRolledbackInstanceCount;
            FailedRolledbackInstanceCount = failedRolledbackInstanceCount;
            RollbackError = rollbackError;
        }

        /// <summary> The number of instances which have been successfully rolled back. </summary>
        public int? SuccessfullyRolledbackInstanceCount { get; }
        /// <summary> The number of instances which failed to rollback. </summary>
        public int? FailedRolledbackInstanceCount { get; }
        /// <summary> Error details if OS rollback failed. </summary>
        public ApiError RollbackError { get; }
    }
}
