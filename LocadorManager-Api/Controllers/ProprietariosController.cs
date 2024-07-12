using LocadorManager_Api.Service;
using Microsoft.AspNetCore.Mvc;

namespace LocadorManager_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProprietariosController : ControllerBase
    {
        IProprietarioService _proprietarioService;
        public ProprietariosController(IProprietarioService proprietarioService)
        {
            _proprietarioService = proprietarioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProprietariosAsync()
        {
            var proprietarios = await _proprietarioService.GetAllProprietariosAsync();

            if (proprietarios == null)
            {
                return NoContent();
            }

            return Ok(proprietarios);
        }

        [HttpGet("bycpf")]
        public async Task<IActionResult> GetProprietarioByCpfCnpj([FromQuery] string cpfCnpj)
        {
            var proprietario = await _proprietarioService.GetProprietarioByCpfCnpjAsync(cpfCnpj);
            if (proprietario is null)
            {
                return NoContent();
            }

            return Ok(proprietario);
        }

        [HttpGet("byid")]
        public async Task<IActionResult> GetProprietarioById([FromQuery] int id)
        {
            var proprietario = await _proprietarioService.GetProprietarioByIdAsync(id);
            if (proprietario is null)
            {
                return NoContent();
            }

            return Ok(proprietario);
        }
    }
}
