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
            Produto produto = await _context.Produtos.Where(p => p.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<ProdutoDTO>(produto);
        }

        public async Task<ProdutoDTO> Create(ProdutoDTO produtoDTO)
        {
            Produto produto = _mapper.Map<Produto>(produtoDTO);
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProdutoDTO>(produto);
        }

        public async Task<ProdutoDTO> Update(ProdutoDTO produtoDTO)
        {
            Produto produto = _mapper.Map<Produto>(produtoDTO);
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProdutoDTO>(produto);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                Produto produto = await _context.Produtos.Where(p => p.Id == id).FirstOrDefaultAsync();
                if(produto == null) return false;

                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
