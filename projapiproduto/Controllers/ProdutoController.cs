using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using projapiproduto.Models;
using projapiproduto.Services;

namespace projapiproduto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoServices _produtoService;

        public ProdutoController(ProdutoServices produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public ActionResult<List<Produto>> Get() =>
            _produtoService.Get();

        
        [HttpGet("{id}", Name = "GetProduto")]
        public ActionResult<Produto> Get(string id)
        {
            var produto = _produtoService.Get(id);

            if (produto == null)
            {
                return NotFound();
            }

            return produto;
        }

        [HttpPost]
        public ActionResult<Produto> Create(Produto produto)
        {
            _produtoService.Create(produto);

            return CreatedAtRoute("GetProduto", new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, Produto produtoIn)
        {
            var produto = _produtoService.Get(id);

            if (produto == null)
            {
                return NotFound();
            }

            _produtoService.Update(id, produtoIn);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var produto = _produtoService.Get(id);

            if (produto == null)
            {
                return NotFound();
            }

            _produtoService.Remove(produto.Id);

            return NoContent();
        }
    }
}