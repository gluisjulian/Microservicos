using AutoMapper;
using GeekShopping.ProductAPI.Data.DTO;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig =  new MapperConfiguration(config =>
            {
                config.CreateMap<ProdutoDTO, Produto>();
                config.CreateMap<Produto, ProdutoDTO>();
            });

            return mappingConfig;
        }
    }
}
