using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetApi.Data;
using dotnetApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

        private readonly DataContext _context; 
        public EventosController(DataContext context)
        {
           _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }


        
    }
}
