using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly DbpruebaContext _dbContext;

        public ContactController(DbpruebaContext context)
        {
            this._dbContext = context;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            List<Contact> lista = await _dbContext.Contacts.OrderByDescending(c => c.IdContact).ToListAsync();
            return StatusCode(StatusCodes.Status200OK, lista);
        }

        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar([FromBody] Contact request)
        {
            await _dbContext.Contacts.AddAsync(request);
            await _dbContext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "OK");
        }

        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult> Editar([FromBody,] Contact request)
        {
            _dbContext.Contacts.Update(request);
            await _dbContext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "OK");
        }

        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            Contact contact = _dbContext.Contacts.Find(id);

            _dbContext.Contacts.Remove(contact);
            await _dbContext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK,"OK");
        }
    }
}
