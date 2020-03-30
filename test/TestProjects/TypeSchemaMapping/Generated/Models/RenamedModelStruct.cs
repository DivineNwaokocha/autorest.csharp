// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using NamespaceForEnums;

namespace CustomNamespace
{
    /// <summary> The ModelStruct. </summary>
    internal readonly partial struct RenamedModelStruct
    {
        /// <summary> Initializes a new instance of RenamedModelStruct. </summary>
        /// <param name="customizedFlattenedStringProperty"> . </param>
        /// <param name="fruit"> Fruit. </param>
        /// <param name="daysOfWeek"> Day of week. </param>
        public RenamedModelStruct(string customizedFlattenedStringProperty, CustomFruitEnum? fruit, CustomDaysOfWeek? daysOfWeek)
        {
            if (customizedFlattenedStringProperty == null)
            {
                throw new ArgumentNullException(nameof(customizedFlattenedStringProperty));
            }
            if (fruit == null)
            {
                throw new ArgumentNullException(nameof(fruit));
            }
            if (daysOfWeek == null)
            {
                throw new ArgumentNullException(nameof(daysOfWeek));
            }

            CustomizedFlattenedStringProperty = customizedFlattenedStringProperty;
            Fruit = fruit;
            DaysOfWeek = daysOfWeek;
        }
        /// <summary> Fruit. </summary>
        public CustomFruitEnum? Fruit { get; }
        /// <summary> Day of week. </summary>
        public CustomDaysOfWeek? DaysOfWeek { get; }
    }
}
