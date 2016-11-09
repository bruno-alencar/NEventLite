﻿using NEventLite_Example.Util;
using ServiceStack.Redis;

namespace NEventLite_Example.Storage
{
    class MyRedisSnapshotStorageProvider:NEventLite_Storage_Providers.Redis.RedisSnapshotStorageProvider
    {
        public override IRedisClientsManager GetClientsManager()
        {
            return RedisConnection.GetClientManager();
        }
    }
}
