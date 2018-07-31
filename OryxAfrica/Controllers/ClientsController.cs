using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OryxAfrica.Data;
using OryxAfrica.Models;

namespace OryxAfrica.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        
        public ClientsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clients.ToListAsync());
        }

     

        
    }
}