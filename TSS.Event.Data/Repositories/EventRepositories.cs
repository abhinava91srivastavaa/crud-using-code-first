using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSS.Event.Data.Contract;
using data = TSS.Event.Data.Model;

namespace TSS.Event.Data.Repositories
{
    class EventRepositories: IEventRepositories
    {
        EventDBContext context = new EventDBContext();
        public void Add(data.Event e)
        {
            context.Event.Add(e);
            context.SaveChanges();
        }

        public void Update(data.Event e)
        {
            context.Entry(e).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            data.Event e = context.Event.Find(Id);
            context.Event.Remove(e);
            context.SaveChanges();


        }

        public IEnumerable<data.Event> GetAll()
        {
            return context.Event;
        }

        public data.Event GetEventById(int Id)
        {
            var events = (from e in context.Event where e.Id == Id select e).FirstOrDefault();
            return events;
        }
    }
}
