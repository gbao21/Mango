using Mango.Web.Models;

namespace Mango.Web.Service.ISErvice
{
    public interface IBaseService
    {
      Task<ResponseDto?>  SendAsync(RequestDto requestDTO);
    }
}
