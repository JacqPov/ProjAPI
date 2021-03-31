using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projrelatorio.Dto;
using projrelatorio.Services;

namespace projrelatorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportClienteController : ControllerBase
    {
        private MongoService _mongoService;

        public ReportClienteController()
        {
            _mongoService = new MongoService();
        }

        [HttpGet]
        public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
        {
            return await _mongoService.GetClienteAsync();
        }

    }
}