﻿using System;
using System.Collections.Generic;

using Microsoft.ServiceBus.Management;

using Newtonsoft.Json;

namespace Woodpecker.Core.DocumentDb.Model
{
    public class MetricModel
    {
        public string Name { get; set; }

        public DateTime TimeStamp { get; set; }

        public double? Average { get; set; }


        public long? Count { get; set; }

        public double? Maximum { get; set; }

        public double? Minimum { get; set; }

        public double? Total { get; set; }
    }
}
