// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace
{
    public partial class LabelListResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("items");
            writer.WriteStartArray();
            foreach (var item in Items)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("@nextLink");
            writer.WriteStringValue(@nextLink);
            writer.WriteEndObject();
        }

        internal static global::.LabelListResult DeserializeLabelListResult(JsonElement element)
        {
            System.Collections.Generic.IList < global::.Label > items = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("items"))
                {
                    System.Collections.Generic.List < global::.Label > array = new List<global::.Label>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(global::.Label.DeserializeLabel(item));
                    }
                    items = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new global::.LabelListResult(items, nextLink);
        }

        internal RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal static global::.LabelListResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLabelListResult(document.RootElement);
        }
    }
}
