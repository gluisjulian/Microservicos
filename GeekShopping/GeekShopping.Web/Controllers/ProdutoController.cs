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
    }
}
