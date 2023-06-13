using AutoMapper;
using GeekShopping.ProductAPI.Data.DTO;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly GeekShoppingContext _context;
        private IMapper _mapper;

        public ProdutoRepository(GeekShoppingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ProdutoDTO>> FindAll()
        {
            List<Produto> produtos = await _context.Produtos.ToListAsync();
            return _mapper.Map<List<ProdutoDTO>>(produtos);
        }

        public async Task<ProdutoDTO> FindById(long id)
        {
            Produto produto = await _context.Produtos.Where(p => p.Id == id);
            return _mapper.Map<ProdutoDTO>(produto);
        }

        public Task<ProdutoDTO> Create(ProdutoDTO produtoDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoDTO> Update(ProdutoDTO produtoDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
