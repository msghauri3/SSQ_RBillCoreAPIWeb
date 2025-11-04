using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SSQ_RBillCoreAPIWeb.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SSQ_RBillCoreAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceController : ControllerBase
    {
        private readonly RBillWebDBContext _context;

        public MaintenanceController(RBillWebDBContext context)
        {
            _context = context;
        }

        // ✅ Get maintenance records by NewRefrence (double)
        [HttpGet]
        public async Task<IActionResult> GetByNewRefrence(double newRef)
        {
            var records = await _context.Maintenance
                .Where(x => x.NewRefrence == newRef)
                .ToListAsync();

            if (records == null || records.Count == 0)
                return NotFound($"No record found for NewRefrence = {newRef}");

            return Ok(records);
        }
    }
}
