﻿namespace Members.Sync.Next.EventSourcing.Infra
{
    public class CassandraProvider
    {
    }

    public static class CassandraUtils
    {
        public static string GenerateTimeUUID()
        {
            return Cassandra.TimeUuid.NewId().ToString();
        }
    }
}
