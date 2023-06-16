using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProdutoService
    {
        Task<IEnumerable<ProdutoModel>> GetAllProdutos();
        Task<ProdutoModel> FindById(long id);
        Task<ProdutoModel> CreateProduto(ProdutoModel model);
        Task<ProdutoModel> UpdateProduto(ProdutoModel model);
        Task<bool> DeleteProduto(long id);
    }
}
