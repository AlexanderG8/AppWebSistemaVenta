using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            using (BDVentasContext db = new BDVentasContext()) 
            {
                var lista = db.Clientes.ToList();
                return Ok(lista);
            }
        }
    }
}
