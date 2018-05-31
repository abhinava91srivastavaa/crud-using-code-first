using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Event.Data.Repositories;
using data = TSS.Event.Data.Model;
using domain = TSS.Event.Domain.Model;
using TSS.Event.Domain.Contract;

namespace TSS.Event.Data.Service
{

    public class EventService : IEventService
    {
        EventRepositories eventReopsitories = new EventRepositories();

        public void Add(domain.Event domainEvent)
        {

            data.Event dataEvent = new data.Event();
            dataEvent.Name = domainEvent.Name;
            dataEvent.Description = domainEvent.Description;
            dataEvent.Date = domainEvent.Date;
            dataEvent.Vanue = domainEvent.Vanue;
            dataEvent.ContactPerson = domainEvent.ContactPerson;
            dataEvent.EmailId = domainEvent.EmailId;
            dataEvent.CreatedDate = DateTime.Now;
            dataEvent.UpdatedDate = DateTime.Now;

            eventReopsitories.Add(dataEvent);

        }

        public void Update(domain.Event domainEvent)
        {
            data.Event dataEvent = new data.Event();
            dataEvent.Id = domainEvent.Id;
            dataEvent.Name = domainEvent.Name;
            dataEvent.Description = domainEvent.Description;
            dataEvent.Date = domainEvent.Date;
            dataEvent.Vanue = domainEvent.Vanue;
            dataEvent.ContactPerson = domainEvent.ContactPerson;
            dataEvent.EmailId = domainEvent.EmailId;
            dataEvent.CreatedDate = DateTime.Now;
            dataEvent.UpdatedDate = DateTime.Now;

            eventReopsitories.Update(dataEvent);
        }

        public void Delete(int Id)
        {
            eventReopsitories.Delete(Id);
        }

        public IEnumerable<domain.Event> GetEvent()
        {
            var events = eventReopsitories.GetAll();
            var domainEvents = events.Select(e => new domain.Event
            {
                Id = e.Id,
                Name = e.Name,
                Description=e.Description,
                Date=e.Date,
                Vanue=e.Vanue ,
                ContactPerson=e.ContactPerson,
                EmailId=e.EmailId,               

            });
            return domainEvents;
        }

        public domain.Event GetEventById(int Id)
        {
            var events = eventReopsitories.GetEventById(Id);
            domain.Event obj = new domain.Event()
            {
                Id=events.Id,
                Name=events.Name,
                Description=events.Description,
                Date = events.Date,
                Vanue=events.Vanue,
                ContactPerson = events.ContactPerson,
                EmailId=events.EmailId,

            };
           return obj;
        }
    }
}
