using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Rocket_Elevator_RESTApi.Models
{
    public class Customer
    {
        public int id { get; }
        public string cpy_contact_email {get; set;}
    }
}