using System;

namespace PoC.Mapeador.AutoMapper.Models
{
    public class ProductResponse
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Status { get; set; }
    }
}