using CoolEventsWeb.Models;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEventsWeb.ViewModels
{
    public class EventViewModel
    {
        public IEnumerable<Event> Event { get; set; }
    }
}