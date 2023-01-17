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
    public class StaffsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public MakesController(ApplicationDbContext context)
        public StaffsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Make>>> GetStaffs()
        public async Task<IActionResult> GetStaff()
        {
            //Refactored
            //return await _context.Makes.ToListAsync();
            var staffs = await _unitOfWork.Staffs.GetAll();
            return Ok(staffs);
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetStaff(int id)
        {
            //Refactored
            //var make = await _context.Makes.FindAsync(id);
            var staff = await _unitOfWork.Staffs.Get(q => q.StaffID == id);

            if (staff == null)
            {
                return NotFound();
            }

            return Ok(staff);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff staff)
        {
            if (id != staff.StaffID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Staffs.Update(staff);

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
                if (!await StaffExists(id))
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

        // POST: api/Staffs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Staff>> PostStaff(Staff staff)
        {
            //Refactored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staffs.Insert(staff);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = staff.StaffID }, staff);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {
            //Refactored
            //var make = await _context.Makes.FindAsync(id);
            var staff = await _unitOfWork.Staffs.Get(q => q.StaffID == id);

            if (staff == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool MakeExists(int id)
        private async Task<bool> StaffExists(int id)
        {
            //Refactored
            //return _context.Makes.Any(e => e.Id == id);       
            var staff = await _unitOfWork.Staffs.Get(q => q.StaffID == id);
            return staff != null;
        }
    }
}

