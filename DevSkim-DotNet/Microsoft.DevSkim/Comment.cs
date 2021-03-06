﻿// Copyright (C) Microsoft. All rights reserved. Licensed under the MIT License.

using Newtonsoft.Json;

namespace Microsoft.DevSkim
{
    /// <summary>
    ///     Comment class to hold information about comment for each language
    /// </summary>
    internal class Comment
    {
        [JsonProperty(PropertyName = "inline")]
        public string? Inline { get; set; }

        [JsonProperty(PropertyName = "language")]
        public string[]? Languages { get; set; }

        [JsonProperty(PropertyName = "preffix")]
        public string? Prefix { get; set; }

        [JsonProperty(PropertyName = "suffix")]
        public string? Suffix { get; set; }
    }
}