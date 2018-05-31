using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using domain = TSS.Event.Domain.Model;
using data = TSS.Event.Data.Model;
using TSS.Event.Domain.Contract;
using TSS.Event.Data.Service;

namespace TSS.Event.API.Controllers
{
    [RoutePrefix("api/events")]
    public class EventController : ApiController
    {
        private IEventService _eventService; 
        public EventController(IEventService service)
        {
            _eventService = service;
        }
        

        [Route("")]
        [HttpPost]
        public IHttpActionResult Add(domain.Event domainEvent)
        {
            if(domainEvent==null)
            {
                return BadRequest("Invalid Request");
            }
            _eventService.Add(domainEvent);
            return Ok();
        }

        [Route("")]
        [HttpPut]
        public IHttpActionResult Update(domain.Event domainEvent)
        {
            if (domainEvent == null)
            {
                return BadRequest("Invalid Request");
            }
            _eventService.Update(domainEvent);
            return Ok();
        }
        
        [Route("")]
        [HttpDelete]
        public IHttpActionResult Delete(int Id)
        {
            if (Id <= 0)
            {
                return BadRequest("Invalid Request");
            }
            _eventService.Delete(Id);
            return Ok();
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult GetEvents()
        {
            var events = _eventService.GetEvent();
            return Ok(events);
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult GetEvents( int Id)
        {
            var events = _eventService.GetEventById(Id);
            return Ok(events);
        }
    }
}
