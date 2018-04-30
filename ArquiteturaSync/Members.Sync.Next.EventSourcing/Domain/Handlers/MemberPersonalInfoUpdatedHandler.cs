﻿using System.Threading.Tasks;
using Members.Sync.Next.EventSourcing.Domain.Events;
using Members.Sync.Next.EventSourcing.Infra;

namespace Members.Sync.Next.EventSourcing.Domain.Handlers
{
    public class MemberPersonalInfoUpdatedHandler
    {
        public MemberPersonalInfoUpdatedHandler(ICassandraEventStore eventStore)
        {
            _eventStore = eventStore;
        }

        private readonly ICassandraEventStore _eventStore;

        public async Task<bool> HandleMemberAsync(MemberPersonalInfoUpdatedEvent @event)
        {
            //TODO: Tratar o evento
            await _eventStore.SaveEventAsync("im an AggregateRoot ID", @event);

            //TODO: Tratar retorno
            return true;
        }
    }
}
