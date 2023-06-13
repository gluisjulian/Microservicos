using GeekShopping.ProductAPI.Data.DTO;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<ProdutoDTO>> FindAll();
        Task<ProdutoDTO> FindById(long id);
        Task<ProdutoDTO> Create(ProdutoDTO produtoDTO);
        Task<ProdutoDTO> Update(ProdutoDTO produtoDTO);
        Task<bool> Delete(long id);
    }
}
