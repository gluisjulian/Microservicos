using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService ?? throw new ArgumentNullException(nameof(produtoService));
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _produtoService.GetAllProdutos();
            return View(produtos);
        }

        public async Task<IActionResult> ProdutoCreate()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ProdutoCreate(ProdutoModel model)
        {
            if(ModelState.IsValid) 
            {
                var produto = _produtoService.CreateProduto(model);
                if(Response != null)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }
    }
}
