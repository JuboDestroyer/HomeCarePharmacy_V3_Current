using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeCarePharmacy_V3.Server.Data;
using HomeCarePharmacy_V3.Shared.Domain;
using HomeCarePharmacy_V3.Server.IRepository;

namespace HomeCarePharmacy_V3.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public StaffsController(ApplicationDbContext context)
        public StaffsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Staffs
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Staff>>> GetStaffs()
        public async Task<IActionResult> GetStaffs()
        {
            var consultations = await _unitOfWork.Staffs.GetAll();
            return Ok(consultations);
            //return await _context.Staffs.ToListAsync();
        }

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Staff>> GetStaff(int id)
        public async Task<IActionResult> GetStaff(int id)
        {

            //var consultation = await _context.Staffs.FindAsync(id);
            var consultation = await _unitOfWork.Staffs.Get(q => q.StaffId == id);

            if (consultation == null)
            {
                return NotFound();
            }

            return Ok(consultation);
        }

        // PUT: api/Staffs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff(int id, Staff consultation)
        {
            if (id != consultation.StaffId)
            {
                return BadRequest();
            }

            //_context.Entry(consultation).State = EntityState.Modified;
            _unitOfWork.Staffs.Update(consultation);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
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
        public async Task<ActionResult<Staff>> PostStaff(Staff consultation)
        {

            //_context.Staffs.Add(consultation);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Staffs.Insert(consultation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetStaff", new { id = consultation.StaffId }, consultation);
        }

        // DELETE: api/Staffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(int id)
        {

            //var consultation = await _context.Staffs.FindAsync(id);
            var consultation = await _unitOfWork.Staffs.Get(q => q.StaffId == id);

            if (consultation == null)
            {
                return NotFound();
            }

            //_context.Staffs.Remove(consultation);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Staffs.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool StaffExists(int id)
        private async Task<bool> StaffExists(int id)
        {
            //return (_context.Staffs?.Any(e => e.StaffId == id)).GetValueOrDefault();
            var consultation = await _unitOfWork.Staffs.Get(q => q.StaffId == id);
            return consultation != null;
        }
    }
}
