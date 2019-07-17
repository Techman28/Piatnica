
using ITMCode.Piatnica.Bll.Services.DelayService;
using ITMCode.Piatnica.Bll.Services.EventHistoryService;

namespace ITMCode.Piatnica.Bll.Services
{
    public interface IServiceFactory
    {
        IOrderService OrderService { get; }
        IDelayService DelayService { get; }

        IEventHistoryService EventHistoryService { get; }

    }
}