using QueViagem.Data;
using QueViagem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace QueViagem.Controllers 
{

    [ApiController]
    [Route("api/[controller]")]
    public class DestinosController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public DestinosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destinos>>> GetDestinos()
        {
            return await _dataContext.Destinos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Destinos>> GetDestinosById(int id)
        {
            var destino = await _dataContext.Destinos.FindAsync(id);

            if (destino == null)
            {
                return NotFound();
            }

            return Ok(destino) ;
        }


        
    }

}