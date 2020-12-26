using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rocket_Elevator_RESTApi.Models;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.AspNetCore.JsonPatch;

namespace Rocket_Elevator_RESTApi.Controllers
{
    [Route("api/Customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly InformationContext _context;

        public CustomersController(InformationContext context)
        {
            _context = context;
        }

        
        
    [HttpGet("{cpy_contact_email}")]
        public async Task<ActionResult<Customer>> GetCustomersEmail(string cpy_contact_email)
        {  
            
            var customer = await _context.customers.FindAsync(cpy_contact_email);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
                
        }    
    }

}