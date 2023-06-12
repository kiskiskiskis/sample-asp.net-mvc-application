using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProducersController(AppDbContext context)
        {
            _appDbContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _appDbContext.Producers.ToListAsync();
            return View(data);
        }
    }
}
