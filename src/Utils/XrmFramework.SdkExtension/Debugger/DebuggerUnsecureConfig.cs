﻿using System;
using System.Collections.Generic;
using System.Text;
#if INTERNAL_NEWTONSOFT
using Newtonsoft.Json.Xrm;
#else 
using Newtonsoft.Json;
#endif

namespace XrmFramework.RemoteDebugger
{
    [JsonObject]
    class DebuggerUnsecureConfig
    {
        [JsonProperty("debugSessions")]
        public List<Guid> DebugSessionIds { get; set; }
    }
}
