using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaicesBlazor.Shared.Modelos;

namespace RaicesBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasificacionController : Controller
    {
        private readonly ApplicationDBContext context;
        public IActionResult Index()
        {
            return View();
        }

        public ClasificacionController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Clasificacion>>> Get()
        {
            return await context.Clasificacion.ToListAsync();
        }

        [HttpPost]
        public void Post(Clasificacion clasificacion)
        {
            try
            {
                context.Clasificacion.Add(clasificacion);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Clasificacion? u = context.Clasificacion.Find(id);
                if (u != null)
                {
                    return Ok(u);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        [HttpPut]
        public void Put(Clasificacion clasificacion)
        {
            context.Entry(clasificacion).State = EntityState.Modified;
            context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Clasificacion? clasificacion = context.Clasificacion.Find(id);
                if (clasificacion != null)
                {
                    context.Clasificacion.Remove(clasificacion);
                    context.SaveChanges();
                    return Ok();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
