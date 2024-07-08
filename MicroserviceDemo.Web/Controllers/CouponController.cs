using MicroserviceDemo.Web.Models;
using MicroserviceDemo.Web.Models.Dto;
using MicroserviceDemo.Web.Service.IService;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MicroserviceDemo.Web.Controllers
{
    public class CouponController(ICouponService couponService) : Controller
    {
        public async Task<IActionResult> CouponIndex()
        {
            List<CouponDto>? list = new();
            ResponseDto? response = await couponService.GetAllCouponsAsync();

            if (response != null && response.IsSuccess == true)
            {
                list = JsonConvert.DeserializeObject<List<CouponDto>>(Convert.ToString(response.Result));
            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(list);
        }

        public async Task<IActionResult> CouponCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CouponCreate(CouponDto coupon)
        {
            if (ModelState.IsValid)
            {
                ResponseDto? response = await couponService.CreateCouponsAsync(coupon);

                if (response != null && response.IsSuccess == true)
                {
                    TempData["success"] ="Coupon created successfully";
                    return RedirectToAction(nameof(CouponIndex));
                }
                else
                {
                    TempData["error"] = response?.Message;
                }
            }
            return View(coupon);
        }

        public async Task<IActionResult> CouponDelete(int couponId)
        {
            ResponseDto? response = await couponService.GetCouponsByIdAsync(couponId);
            CouponDto coupon;
            if (response != null && response.IsSuccess == true)
            {
                CouponDto? model = JsonConvert.DeserializeObject<CouponDto>(Convert.ToString(response.Result));
                return View(model);
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CouponDelete(CouponDto coupon)
        {
            ResponseDto? response = await couponService.DeleteCouponsAsync(coupon.CouponId);

            if (response != null && response.IsSuccess == true)
            {
                TempData["success"] = "Coupon deleted successfully";
                return RedirectToAction(nameof(CouponIndex));
            }
            else
            {
                TempData["error"] = response?.Message;
            }

            return View(coupon);
        }
    }
}