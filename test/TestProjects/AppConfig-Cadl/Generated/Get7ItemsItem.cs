// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace
{
    /// <summary> // TODO: (missing-description) Add description. </summary>
    public readonly partial struct Get7ItemsItem : IEquatable<global::.Get7ItemsItem>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Get7ItemsItem"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Get7ItemsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyValue = "key";
        private const string LabelValue = "label";
        private const string ContentTypeValue = "content_type";
        private const string ValueValue = "value";
        private const string LastModifiedValue = "last_modified";
        private const string TagsValue = "tags";
        private const string LockedValue = "locked";
        private const string EtagValue = "etag";

        /// <summary> key. </summary>
        public static global::.Get7ItemsItem Key { get; } = new global::.Get7ItemsItem(KeyValue);
        /// <summary> label. </summary>
        public static global::.Get7ItemsItem Label { get; } = new global::.Get7ItemsItem(LabelValue);
        /// <summary> content_type. </summary>
        public static global::.Get7ItemsItem ContentType { get; } = new global::.Get7ItemsItem(ContentTypeValue);
        /// <summary> value. </summary>
        public static global::.Get7ItemsItem Value { get; } = new global::.Get7ItemsItem(ValueValue);
        /// <summary> last_modified. </summary>
        public static global::.Get7ItemsItem LastModified { get; } = new global::.Get7ItemsItem(LastModifiedValue);
        /// <summary> tags. </summary>
        public static global::.Get7ItemsItem Tags { get; } = new global::.Get7ItemsItem(TagsValue);
        /// <summary> locked. </summary>
        public static global::.Get7ItemsItem Locked { get; } = new global::.Get7ItemsItem(LockedValue);
        /// <summary> etag. </summary>
        public static global::.Get7ItemsItem Etag { get; } = new global::.Get7ItemsItem(EtagValue);
        /// <summary> Determines if two <see cref="Get7ItemsItem"/> values are the same. </summary>
        public static bool operator ==(global::.Get7ItemsItem left, global::.Get7ItemsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Get7ItemsItem"/> values are not the same. </summary>
        public static bool operator !=(global::.Get7ItemsItem left, global::.Get7ItemsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Get7ItemsItem"/>. </summary>
        public static implicit operator global::.Get7ItemsItem(string value) => new global::.Get7ItemsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is global::.Get7ItemsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(global::.Get7ItemsItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
