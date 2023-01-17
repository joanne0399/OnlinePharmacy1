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
    public class OrderItemsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public MakesController(ApplicationDbContext context)
        public OrderItemsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/OrderItems
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Make>>> GetOrderItems()
        public async Task<IActionResult> GetOrderItem()
        {
            //Refactored
            //return await _context.Makes.ToListAsync();
            var orderitems = await _unitOfWork.OrderItems.GetAll(includes: q => q.Include(x => x.Order).Include(x => x.Medication));
            return Ok(orderitems);
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetOrderItem(int id)
        {
            //Refactored
            //var make = await _context.Makes.FindAsync(id);
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.OrderItemID == id);

            if (orderitem == null)
            {
                return NotFound();
            }

            return Ok(orderitem);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderitem)
        {
            if (id != orderitem.OrderItemID)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(make).State = EntityState.Modified;
            _unitOfWork.OrderItems.Update(orderitem);

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
                if (!await OrderItemExists(id))
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

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderitem)
        {
            //Refactored
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OrderItems.Insert(orderitem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOrderItem", new { id = orderitem.OrderItemID }, orderitem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            //Refactored
            //var make = await _context.Makes.FindAsync(id);
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.OrderItemID == id);

            if (orderitem == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitOfWork.OrderItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool MakeExists(int id)
        private async Task<bool> OrderItemExists(int id)
        {
            //Refactored
            //return _context.Makes.Any(e => e.Id == id);       
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.OrderItemID == id);
            return orderitem != null;
        }
    }
}
