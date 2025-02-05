// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> The SKU of the storage account. </summary>
    public partial class StorageSku
    {
        /// <summary> Initializes a new instance of StorageSku. </summary>
        /// <param name="name"> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </param>
        public StorageSku(StorageSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of StorageSku. </summary>
        /// <param name="name"> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </param>
        /// <param name="tier"> The SKU tier. This is based on the SKU name. </param>
        internal StorageSku(StorageSkuName name, StorageSkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called accountType. </summary>
        public StorageSkuName Name { get; set; }
        /// <summary> The SKU tier. This is based on the SKU name. </summary>
        public StorageSkuTier? Tier { get; }
    }
}
