using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rocket_Elevator_RESTApi.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Rocket_Elevator_RESTApi.Controllers
{
   
    [Route("api/Interventions")]
    [ApiController]
    public class InterventionsController : ControllerBase
    {
        private readonly InformationContext _context;

        public InterventionsController(InformationContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Intervention>>> GetIntervention()
        {            
          ////This return all leads created in the last Month 
           

            var queryInterventions = from intervention in _context.interventions
                             where intervention.date_of_intervention == null && intervention.status == "pending"
                             select intervention;

            return await queryInterventions.ToListAsync();    
        }  
        [HttpGet("{id}")]
        public async Task<ActionResult<Intervention>> GetIntervention(long id)
        {
            var intervention = await _context.interventions.FindAsync(id);

            if (intervention == null)
            {
                return NotFound();
            }

            return intervention;
        }
        [HttpPatch("{id}")]
        public async Task<ActionResult<Intervention>> Patch(int id, [FromBody]JsonPatchDocument<Intervention> info)
        {
            
            var intervention = await _context.interventions.FindAsync(id);

            info.ApplyTo(intervention);
            await _context.SaveChangesAsync();

            return intervention;
        }
        

    }





}