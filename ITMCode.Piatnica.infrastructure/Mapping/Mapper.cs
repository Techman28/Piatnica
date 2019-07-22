using AutoMapper;
using ITMCode.Piatnica.Api.DTOs;
using ITMCode.Piatnica.Api.Models;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Infrastucture.Mapping
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            #region From Dal to Bll

            CreateMap<Order, OrderBllModel>().ReverseMap();
            CreateMap<LocationHistory, LocationHistoryBllModel>().ReverseMap();
            CreateMap<OrderState, OrderStateBllModel>().ReverseMap();
            CreateMap<OrderEntry, OrderEntryBllModel>().ReverseMap();
            CreateMap<Delay, DelayBllModel>().ReverseMap();
            CreateMap<EventHistory, EventHistoryBllModel>().ReverseMap();
            CreateMap<Vechicle, VechicleBllModel>().ReverseMap();
            CreateMap<Driver, DriverBllModel>().ReverseMap();


            #endregion

            #region From Bll to ApiModels

            CreateMap<OrderBllModel, OrderApiModel>().ReverseMap();
            CreateMap<LocationHistoryBllModel, LocationHistoryApiModel>().ReverseMap();
            CreateMap<OrderEntryBllModel, OrderEntryApiModel>().ReverseMap();
            CreateMap<OrderStateBllModel, OrderStateApiModel>().ReverseMap();
            CreateMap<DelayBllModel, DelayApiModel>().ReverseMap();
            CreateMap<EventHistoryBllModel, EventHistoryApiModel>().ReverseMap();
            CreateMap<VechicleBllModel, VechicleApiModel >().ReverseMap();
            CreateMap<DriverBllModel, DriverApiModel>().ReverseMap();

            CreateMap<UpdateDelayDto, OrderBllModel>().ReverseMap();
            CreateMap<OrderEntryDto, OrderEntryBllModel>().ReverseMap();
            CreateMap<OrderStateDto, OrderStateBllModel>().ReverseMap();
            CreateMap<LocationHistoryDto, LocationHistoryBllModel>().ReverseMap();
            CreateMap<DelayDto, DelayBllModel>().ReverseMap();
            CreateMap<VechicleDto, VechicleBllModel>().ReverseMap();
            CreateMap<DriverDto, DriverBllModel>().ReverseMap();
            CreateMap<EventHistoryDto, EventHistoryBllModel>().ReverseMap();




            #endregion





        }
    }
}
