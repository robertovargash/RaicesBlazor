using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaicesBlazor.Shared.Modelos;

namespace RaicesBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MercanciaController : Controller
    {
        private readonly ApplicationDBContext context;
        public IActionResult Index()
        {            
            return View();
        }
        public MercanciaController(ApplicationDBContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Mercancia>>> Get()
        {
            return await context.Mercancia.ToListAsync();
        }

        [HttpPost]
        public void Post(Mercancia mercancia)
        {
            try
            {
                context.Mercancia.Add(mercancia);
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
                Mercancia? u = context.Mercancia.Find(id);
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
        public void Put(Mercancia merca)
        {
            try
            {
                context.Entry(merca).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Mercancia? merc = context.Mercancia.Find(id);
                if (merc != null)
                {
                    context.Mercancia.Remove(merc);
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
