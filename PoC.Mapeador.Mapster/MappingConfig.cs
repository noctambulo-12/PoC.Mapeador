using Mapster;
using PoC.Mapeador.Mapster.Models;

namespace PoC.Mapeador.Mapster
{
    public static class MappingConfig
    {
        public static TypeAdapterConfig GetTypeAdapterConfig()
        {
            var config = new TypeAdapterConfig();
            config.NewConfig<ProductRequest, ProductResponse>().Map(destiny => destiny.Key, origin => origin.Crypt);
            return config;
        }
    }
}