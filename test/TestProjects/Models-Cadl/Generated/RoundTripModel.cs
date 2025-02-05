// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ModelsInCadl
{
    /// <summary> Model used both as input and output. </summary>
    public partial class RoundTripModel
    {
        /// <summary> Initializes a new instance of RoundTripModel. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredModel"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/> or <paramref name="requiredModel"/> is null. </exception>
        public RoundTripModel(string requiredString, int requiredInt, BaseModelWithDiscriminator requiredModel)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));
            Argument.AssertNotNull(requiredModel, nameof(requiredModel));

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredModel = requiredModel;
        }

        public string RequiredString { get; set; }

        public int RequiredInt { get; set; }

        public BaseModelWithDiscriminator RequiredModel { get; set; }
    }
}
