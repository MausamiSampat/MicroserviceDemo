using MicroserviceDemo.Web.Models;
using MicroserviceDemo.Web.Models.Dto;
using MicroserviceDemo.Web.Service.IService;

namespace MicroserviceDemo.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

        public async Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> DeleteCouponsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetAllCouponsAsync()
        {
            return await _baseService.SendAsync 
        }

        public async Task<ResponseDto?> GetCouponAsync(string couponCode)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> GetCouponsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto)
        {
            throw new NotImplementedException();
        }
    }
}