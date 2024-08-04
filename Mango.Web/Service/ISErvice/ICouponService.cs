using Mango.Web.Models;
using Mango.Web.Models.Models.DTO;

namespace Mango.Web.Service.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCoupon(string couponCode);
        Task<ResponseDto?> GetAllCouponAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> CreateCouponAsync(CouponDTO counponDdto);
        Task<ResponseDto?> UpdateCouponAsync(CouponDTO counponDdto);
        Task<ResponseDto?> DeleteCouponAsync(int id);
    }
}
