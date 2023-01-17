using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy1.Server.Data;
using OnlinePharmacy1.Server.IRepository;
using OnlinePharmacy1.Shared.Domain;

namespace OnlinePharmacy1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultationsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public MakesController(ApplicationDbContext context)
        public ConsultationsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Consultations
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Make>>> GetConsultations()
        public async Task<IActionResult> GetConsultation()
        {
            //Refactored
            //return await _context.Makes.ToListAsync();
            var consultations = await _unitOfWork.Consultations.GetAll(includes: q => q.Include(x => x.Customer).Include(x => x.Staff));
            return Ok(consultations);
        }

        // GET: api/Consultations/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetConsultation(int id)
        {
            //Refactored
            //var make = await _context.Makes.FindAsync(id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.ConsultationID == id);

            if (consultation == null)
            {
                return NotFound();
            }

            return Ok(consultation);
        }

        // PUT: api/Consultations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultation(int id, Consultation consultation)
        {
            if (id != consultation.ConsultationID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Consultations.Update(consultation);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!MakeExists(id))
                if (!await ConsultationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Consultations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Consultation>> PostConsultation(Consultation consultation)
        {
            //Refactored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Consultations.Insert(consultation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConsultation", new { id = consultation.ConsultationID }, consultation);
        }

        // DELETE: api/Consultations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultation(int id)
        {
            //Refactored
            //var make = await _context.Makes.FindAsync(id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.ConsultationID == id);

            if (consultation == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Consultations.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool MakeExists(int id)
        private async Task<bool> ConsultationExists(int id)
        {
            //Refactored
            //return _context.Makes.Any(e => e.Id == id);       
            var consultation = await _unitOfWork.Consultations.Get(q => q.ConsultationID == id);
            return consultation != null;
        }
    }
}
