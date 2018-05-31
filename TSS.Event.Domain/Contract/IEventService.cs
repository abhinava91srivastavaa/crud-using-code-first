using System;
using System.Collections.Generic;
using domain = TSS.Event.Domain.Model;

namespace TSS.Event.Domain.Contract
{
    public interface IEventService
    {
        void Add(domain.Event domainEvent);

        void Update(domain.Event domainEvent);

        void Delete(int Id);

        IEnumerable<domain.Event> GetEvent();

        domain.Event GetEventById(int Id);
    }
}
