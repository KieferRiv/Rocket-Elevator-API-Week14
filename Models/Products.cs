using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Rocket_Elevator_RESTApi.Models
{
    public class Products
    {
        public List<Battery> batteries {get; set;}
        public List<Column> Columns {get; set;}
        public List<Elevator> Elevators {get; set;}
    }
}