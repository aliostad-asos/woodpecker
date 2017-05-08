﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Woodpecker.Core.DocumentDb.Model;

namespace Woodpecker.Core.DocumentDb.Infrastructure
{
    public interface IMonitoringResourceClient
    {
        Task<MetricsResponse> GetResponse(Uri uri);
    }
}