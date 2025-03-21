using Microsoft.AspNetCore.Mvc;
using MediatR;
using Domain.Entities;
using Application.Empresa.Commands.Create;
using Application.Empresa.Commands.Update;
using Application.Empresa.Commands.Delete;
using Application.Empresa.Queries.Get;
using Application.Empresa.Queries.List;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empresas>>> GetAll()
        {
            var query = new GetAllEmpresasQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Empresas>> GetById(long id)
        {
            var query = new GetEmpresaByIdQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<long>> Create([FromBody] CreateEmpresasCommand command)
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] UpdateEmpresasCommand command)
        {
            command.Emp_id = id;
            //if (id != command.Emp_id)
            //{
            //    return BadRequest();
            //}

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
            var command = new DeleteEmpresasCommand { Emp_id = id };
            var result = await _mediator.Send(command);

            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
