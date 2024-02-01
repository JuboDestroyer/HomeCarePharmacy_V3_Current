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
    public class ConsultationsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public ConsultationsController(ApplicationDbContext context)
        public ConsultationsController(IUnitOfWork unitOfWork)
        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/Consultations
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Consultation>>> GetConsultations()
        public async Task<IActionResult> GetConsultations()
        {
            var consultations = await _unitOfWork.Consultations.GetAll(includes: q => q.Include(x => x.Customer).Include(x => x.Staff));
            return Ok(consultations);
            //return await _context.Consultations.ToListAsync();
        }

        // GET: api/Consultations/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Consultation>> GetConsultation(int id)
        public async Task<IActionResult> GetConsultation(int id)
        {

            //var consultation = await _context.Consultations.FindAsync(id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.ConsultationId == id);

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
            if (id != consultation.ConsultationId)
            {
                return BadRequest();
            }

            //_context.Entry(consultation).State = EntityState.Modified;
            _unitOfWork.Consultations.Update(consultation);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
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

            //_context.Consultations.Add(consultation);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Consultations.Insert(consultation);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetConsultation", new { id = consultation.ConsultationId }, consultation);
        }

        // DELETE: api/Consultations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultation(int id)
        {

            //var consultation = await _context.Consultations.FindAsync(id);
            var consultation = await _unitOfWork.Consultations.Get(q => q.ConsultationId == id);

            if (consultation == null)
            {
                return NotFound();
            }

            //_context.Consultations.Remove(consultation);
            //await _context.SaveChangesAsync();

            await _unitOfWork.Consultations.Delete(id);
            await _unitOfWork.Save(HttpContext);


            return NoContent();
        }

        //private bool ConsultationExists(int id)
        private async Task<bool> ConsultationExists(int id)
        {
            //return (_context.Consultations?.Any(e => e.ConsultationId == id)).GetValueOrDefault();
            var consultation = await _unitOfWork.Consultations.Get(q => q.ConsultationId == id);
            return consultation != null;
        }
    }
}
