using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaicesBlazor.Shared.Modelos;

namespace RaicesBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlmacenesController : Controller
    {
        private readonly ApplicationDBContext context;
        public IActionResult Index()
        {
            return View();
        }

        public AlmacenesController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Almacen>>> Get()
        {
            return await context.Almacenes.ToListAsync();
        }

        [HttpPost]
        public void Post(Almacen almacen)
        {
            try
            {
                context.Almacenes.Add(almacen);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        [HttpGet("{id}")]
        public IActionResult ElNombreQueQuiera(int id)
        {
            try
            {
                Almacen u = context.Almacenes.Find(id);
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
        public void Put(Almacen almacen)
        {
            context.Entry(almacen).State = EntityState.Modified;
            context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public IActionResult Meme(int id)
        {
            try
            {
                Almacen? almacen = context.Almacenes.Find(id);
                if (almacen != null)
                {
                    context.Almacenes.Remove(almacen);
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
