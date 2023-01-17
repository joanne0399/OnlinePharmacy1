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
    public class OrdersController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public MakesController(ApplicationDbContext context)
        public OrdersController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Orders
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Make>>> GetOrders()
        public async Task<IActionResult> GetOrder()
        {
            //Refactored
            //return await _context.Makes.ToListAsync();
            var orders = await _unitOfWork.Orders.GetAll(includes: q => q.Include(x =>x.Customer).Include(x => x.Staff));
            return Ok(orders);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetOrder(int id)
        {
            //Refactored
            //var make = await _context.Makes.FindAsync(id);
            var order = await _unitOfWork.Orders.Get(q => q.OrderID == id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.OrderID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.Orders.Update(order);

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
                if (!await OrderExists(id))
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

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            //Refactored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Orders.Insert(order);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOrder", new { id = order.OrderID }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            //Refactored
            //var make = await _context.Makes.FindAsync(id);
            var order = await _unitOfWork.Orders.Get(q => q.OrderID == id);

            if (order == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Orders.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool MakeExists(int id)
        private async Task<bool> OrderExists(int id)
        {
            //Refactored
            //return _context.Makes.Any(e => e.Id == id);       
            var order = await _unitOfWork.Orders.Get(q => q.OrderID == id);
            return order != null;
        }
    }
}
