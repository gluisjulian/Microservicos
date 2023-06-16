using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;

namespace GeekShopping.Web.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly HttpClient _httpClient;
        public const string BasePath = "api/v1/produto";

        public ProdutoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProdutoModel>> GetAllProdutos()
        {
            var response = await _httpClient.GetAsync(BasePath);
            return await response.ReadContentAs<List<ProdutoModel>>();
        }

        public async Task<ProdutoModel> FindById(long id)
        {
            var response = await _httpClient.GetAsync($"{BasePath}/{id}");
            return await response.ReadContentAs<ProdutoModel>();
        }

        public async Task<ProdutoModel> CreateProduto(ProdutoModel model)
        {
            var response = await _httpClient.PostAsJson(BasePath, model);
            
            if(response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<ProdutoModel>();
            }
            else
            {
                throw new Exception("Algo deu errado ao chamar a API.");
            }
        }

        public async Task<ProdutoModel> UpdateProduto(ProdutoModel model)
        {
            var response = await _httpClient.PutAsJson(BasePath, model);

            if (response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<ProdutoModel>();
            }
            else
            {
                throw new Exception("Algo deu errado ao chamar a API.");
            }
        }

        public async Task<bool> DeleteProduto(long id)
        {
            var response = await _httpClient.DeleteAsync($"{BasePath}/{id}");
            if(response.IsSuccessStatusCode)
            {
                return await response.ReadContentAs<bool>();
            }
            else
            {
                throw new Exception("Algo deu errado ao chamar a API.");
            }
        }
    }
}
