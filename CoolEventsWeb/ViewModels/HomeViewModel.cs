using CoolEventsWeb.Models;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEventsWeb.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<User> User { get; set; }
        public IEnumerable<Event> Event { get; set; }
        public IEnumerable<Ticket> Ticket { get; set; }
    }
}