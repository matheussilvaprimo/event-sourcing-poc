﻿using System;
using System.Threading.Tasks;
using DotzNext.EventStore;
using Members.Sync.Next.EventSourcing.Domain.Aggregates;
using Members.Sync.Next.EventSourcing.Domain.Events;

namespace Members.Sync.Next.EventSourcing.Infra
{
    public interface IAggregateEventStore : IEventStore<MemberAggregateRoot, BaseMemberEvent> 
    {
        Task SaveAggregateAsync(MemberAggregateRoot aggregate);
        Task<MemberAggregateRoot> GetAggregateAsync(Func<MemberAggregateRoot, bool> predicate);
    }
}