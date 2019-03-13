﻿// Copyright (c) Christophe Gondouin (CGO Conseils). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model.Sdk.Metadata
{
    [DataContract]
    public class ModelMetadata
    {
        [DataMember(Name = "entities")]
        public IList<EntityMetadata> Entities { get; set; } = new List<EntityMetadata>();

        [DataMember(Name = "enums")]
        public IList<EnumMetadata> Enums { get; set; } = new List<EnumMetadata>();
    }
}