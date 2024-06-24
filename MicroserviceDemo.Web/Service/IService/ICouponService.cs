﻿using MicroserviceDemo.Web.Models;
using MicroserviceDemo.Web.Models.Dto;

namespace MicroserviceDemo.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);

        Task<ResponseDto?> GetAllCouponsAsync();

        Task<ResponseDto?> GetCouponsByIdAsync(int id);

        Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);

        Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);

        Task<ResponseDto?> DeleteCouponsAsync(int id);
    }
}