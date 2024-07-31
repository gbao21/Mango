namespace Mango.Services.CouponAPI.Models.DTO
{
    public class CouponDTO
    {
            public int CouponId { get; set; }
            public string CouponCode { get; set; }
            public double DiscouuntAmount { get; set; }
            public int MinAmount { get; set; }
    }
}
