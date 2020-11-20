
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace Rocket_Elevator_RESTApi.Models
{
public class Intervention
    {
        public long? id { get; set; }
        public int? author_id { get; set; }
        public int? customer_id { get; set; }
        public int? building_id { get; set; }
        public int? battery_id { get; set; }
        public int? column_id { get; set; }
        public int? elevator_id { get; set; }
        public int? employee_id { get; set; }
        public string? time_of_intervention { get; set; }
        public string? date_of_intervention { get; set; }
        public string? result { get; set; }
        public string? report { get; set; }
        public string? status { get; set; }

    }
}