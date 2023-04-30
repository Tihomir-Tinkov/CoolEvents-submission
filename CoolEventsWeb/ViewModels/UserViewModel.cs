using CoolEventsWeb.Models;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEventsWeb.ViewModels
{
    public class UserViewModel
    {
        public IEnumerable<User> User { get; set; }
        public IEnumerable<Role> Role { get; set; }
    }
}