using MicroserviceDemo.Web.Models;
using MicroserviceDemo.Web.Models.Dto;

namespace MicroserviceDemo.Web.Service.IService
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}