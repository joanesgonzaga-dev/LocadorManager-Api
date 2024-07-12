using LocadorManager_Api.Model.Imovel;
using LocadorManager_Api.Service;
using Microsoft.AspNetCore.Mvc;

namespace LocadorManager_Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ImovelController : ControllerBase
    {
        IImovelService _imovelService;
        public ImovelController(ImovelService imovelService)
        {
            _imovelService = imovelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetImovelById([FromQuery] int id)
        {
            var imovel = await _imovelService.GetImovelById(id);

            if (imovel == null) { return NotFound(); }
            
            return Ok(imovel);
        }
    }
}
