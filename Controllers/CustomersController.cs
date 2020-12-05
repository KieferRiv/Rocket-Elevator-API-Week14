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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomersEmail()
        {  
            return await _context.customers
            .ToListAsync();

                
        } 
        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetCustomerInfos(int id) 
        {
            var products = await _context.Products.FindAsync(id);

            if(products == null) 
            {
                return null;
            }

            return products;
        }       
    }

}