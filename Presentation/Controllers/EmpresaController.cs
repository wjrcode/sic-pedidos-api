using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Commands.Empresas;
using Domain.Entities;
using Application.Queries.Empresas;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmpresaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Empresa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empresa>>> GetAll()
        {
            var query = new GetAllEmpresasQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        // GET: api/Empresa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empresa>> GetById(long id)
        {
            var query = new GetEmpresaByIdQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/Empresa
        [HttpPost]
        public async Task<ActionResult<long>> Create([FromBody] CreateEmpresaCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);
                return CreatedAtAction(nameof(GetById), new { id = result }, result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            
        }

        // PUT: api/Empresa/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] UpdateEmpresaCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            var result = await _mediator.Send(command);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/Empresa/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var command = new DeleteEmpresaCommand { Id = id };
            var result = await _mediator.Send(command);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
