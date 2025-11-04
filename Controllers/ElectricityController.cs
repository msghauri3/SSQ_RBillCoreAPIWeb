using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSQ_RBillCoreAPIWeb.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SSQ_RBillCoreAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricityController : ControllerBase
    {
        private readonly RBillWebDBContext _context;

        public ElectricityController(RBillWebDBContext context)
        {
            _context = context;
        }

        // ✅ Get all electricity records
        [HttpGet]
        public async Task<IActionResult> GetByNewRefrence(string newRef)
        {
            var records = await _context.Electricity
                .Where(x => x.NewRefrence == newRef)
                .ToListAsync();

            if (records == null || records.Count == 0)
                return NotFound($"No record found for NewRefrence = {newRef}");

            return Ok(records);
        }
    }
}
