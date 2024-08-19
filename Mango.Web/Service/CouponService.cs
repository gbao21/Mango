using Mango.Web.Models;
using Mango.Web.Models.Models.DTO;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;
        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }

         async Task <ResponseDto?> ICouponService.CreateCouponAsync(CouponDTO counponDdto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = counponDdto,
                Url = SD.CouponAPIBase + "/api/coupon/"
            });
        }

         async Task<ResponseDto?> ICouponService.DeleteCouponAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

         async Task<ResponseDto?> ICouponService.GetAllCouponAsync()
        {   
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon"
            });
        }

         async Task<ResponseDto?> ICouponService.GetCoupon(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/GetByCode/" + couponCode
            });
        }

         async Task<ResponseDto?> ICouponService.GetCouponByIdAsync(int id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/coupon/" + id
            });
        }

         async Task<ResponseDto?> ICouponService.UpdateCouponAsync(CouponDTO counponDdto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.PUT,
                Data = counponDdto,
                Url = SD.CouponAPIBase + "/api/coupon/"
            });
        }
    }
}
