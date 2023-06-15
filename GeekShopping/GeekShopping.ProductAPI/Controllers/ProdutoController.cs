using GeekShopping.ProductAPI.Data.DTO;
using GeekShopping.ProductAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _repository;

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }



        [HttpGet]
        public async Task<ActionResult> FindAll()
        {
            var produtos = await _repository.FindAll();
            if (produtos == null) return NotFound();

            return Ok(produtos);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoDTO>> FindById(long id)
        {
            var produto = await _repository.FindById(id);
            if (produto == null) return NotFound();

            return Ok(produto);
        }


        [HttpPost]
        public async Task<ActionResult<ProdutoDTO>> CreateProduto(ProdutoDTO produtoDTO)
        {
            var produto = await _repository.Create(produtoDTO);
            if (produto == null) return NotFound();

            return Ok(produto);
        }


        [HttpPut]
        public async Task<ActionResult<ProdutoDTO>> EditProduto(ProdutoDTO produtoDTO)
        {
            var produto = await _repository.Update(produtoDTO);
            if (produto == null) return NotFound();

            return Ok(produto);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduto(long id)
        {
            var status = await _repository.Delete(id);
            if (status == false) return BadRequest();

            return Ok(status);
        }
    }
}
