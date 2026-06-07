using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Data;
namespace WebApplication1.Controllers;

public class PatientController
{

    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : Controller
    {
        private readonly IDbService _dbService;
        
        public _dbService =dbService;
    }


    [HttpGet("patients")]
    public async Task<IActionResult> GetPatients()
    {
        try
        {
            var order = await _dbService.GetPatients();
            return Ok(order);
        }
        catch (Exception ex)
        {
            return BadRequest();
        }
        
    }

    [HttpPost]
    public async Task<IActionResult> Post(Patient patient)
    {
        try
        {
            
            _context.Patient.Add(patient);
            _context.Appointment.Add(patient.Appointment);
            await _context.SaveChangesAsync();
        }
        
        
        
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}