// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DetectorSupportTopic
    {
        internal static DetectorSupportTopic DeserializeDetectorSupportTopic(JsonElement element)
        {
            Optional<string> id = default;
            Optional<ResourceIdentifier> pesId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pesId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pesId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new DetectorSupportTopic(id.Value, pesId.Value);
        }
    }
}
