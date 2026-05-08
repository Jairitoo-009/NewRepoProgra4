using Microsoft.AspNetCore.Mvc;

namespace Progra4Quiz.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PruebaController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { mensaje = "¡Hola desde Swagger!", fecha = DateTime.Now });
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new { error = "El ID debe ser mayor a 0" });
            }

            return Ok(new
            {
                id = id,
                mensaje = $"Recibiste el ID: {id}",
                timestamp = DateTime.Now
            });
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return BadRequest(new { error = "El nombre no puede estar vacío" });
            }

            return Ok(new
            {
                mensaje = $"Hola {nombre}, bienvenid@ a tu API",
                recibido = nombre
            });
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string valor)
        {
            return Ok(new
            {
                mensaje = $"Actualizando ID {id} con valor: {valor}",
                id = id,
                nuevoValor = valor
            });
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(new
            {
                mensaje = $"Eliminando el registro con ID: {id}",
                idEliminado = id
            });
        }
    }
}