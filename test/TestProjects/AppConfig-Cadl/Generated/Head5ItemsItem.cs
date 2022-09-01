// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace AppConfiguration
{
    /// <summary> // TODO: (missing-description) Add description. </summary>
    public readonly partial struct Head5ItemsItem : IEquatable<Head5ItemsItem>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Head5ItemsItem"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Head5ItemsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NameValue = "name";

        /// <summary> name. </summary>
        public static Head5ItemsItem Name { get; } = new Head5ItemsItem(NameValue);
        /// <summary> Determines if two <see cref="Head5ItemsItem"/> values are the same. </summary>
        public static bool operator ==(Head5ItemsItem left, Head5ItemsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Head5ItemsItem"/> values are not the same. </summary>
        public static bool operator !=(Head5ItemsItem left, Head5ItemsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Head5ItemsItem"/>. </summary>
        public static implicit operator Head5ItemsItem(string value) => new Head5ItemsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Head5ItemsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Head5ItemsItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
