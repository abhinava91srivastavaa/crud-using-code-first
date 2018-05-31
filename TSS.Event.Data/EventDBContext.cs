using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data = TSS.Event.Data.Model;

namespace TSS.Event.Data
{
    public class EventDBContext:DbContext
    {
        public EventDBContext():base("name=Eventconnectionstring")
        {

        }
        public IDbSet<data.Event> Event { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EventDBContext>(null);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
