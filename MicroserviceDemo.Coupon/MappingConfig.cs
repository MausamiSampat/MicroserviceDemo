using AutoMapper;
using MicroserviceDemo.CouponAPI.Models;
using MicroserviceDemo.CouponAPI.Models.Dto;

namespace MicroserviceDemo.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Coupon, CouponDto>();
                config.CreateMap<CouponDto, Coupon>();

            });
            return mappingConfig;
        }
    }
}
