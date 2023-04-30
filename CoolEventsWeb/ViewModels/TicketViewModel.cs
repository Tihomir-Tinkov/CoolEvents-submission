using CoolEventsWeb.Models;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEventsWeb.ViewModels
{
    public class TicketViewModel
    {
        public IEnumerable<Ticket> Ticket { get; set; }
        public IEnumerable<User> User { get; set; }
        public IEnumerable<Event> Event { get; set; }
    }
}