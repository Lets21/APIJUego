using APIJuego.Data;
using APIJuego.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIJuego.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JuegoController : ControllerBase
    {

        private readonly ApplicationDBContext _db;

        public JuegoController(ApplicationDBContext db)
        {
            _db = db;
        }


        // POST api/juego
        [HttpPost]
        public async Task<IActionResult> RegistrarGanador([FromBody] Juego juego)
        {
            if (ModelState.IsValid)
            {
                juego.GameDateTime = DateTime.Now; // Establecer la hora actual del juego
                _db.Juegos.Add(juego);
                await _db.SaveChangesAsync();
                return Ok(juego);
            }

            return BadRequest();
        }

        // GET api/juego
        [HttpGet]
        public async Task<IActionResult> ObtenerGanadores()
        {
            var juegos = await _db.Juegos.ToListAsync();
            return Ok(juegos);
        }

    }
}
