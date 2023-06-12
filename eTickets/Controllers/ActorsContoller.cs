﻿using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ActorsController(AppDbContext context)
        {
            _appDbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _appDbContext.Actors.ToListAsync();
            return View(data);
        }
    }
}
