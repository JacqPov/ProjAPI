using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projrelatorio.Dto;
using projrelatorio.Services;

namespace projrelatorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportProdutoController : ControllerBase
    {
        private MongoService _mongoService;

        public ReportProdutoController()
        {
            _mongoService = new MongoService();
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
        {
            return await _mongoService.GetProdutoAsync();
        }

    }
}