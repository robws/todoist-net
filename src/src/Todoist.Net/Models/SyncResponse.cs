﻿using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Todoist.Net.Models
{
    public class SyncResponse
    {
        [JsonProperty("sync_status")]
        public Dictionary<Guid, dynamic> SyncStatus { get; set; }

        [JsonProperty("temp_id_mapping")]
        public Dictionary<Guid, int> TempIdMappings { get; set; }
    }
}
