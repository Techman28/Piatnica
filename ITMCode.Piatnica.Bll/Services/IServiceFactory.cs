
using ITMCode.Piatnica.Bll.Services.DelayService;

namespace ITMCode.Piatnica.Bll.Services
{
    public interface IServiceFactory
    {
        IOrderService OrderService { get; }
        IDelayService DelayService { get; }


    }
}