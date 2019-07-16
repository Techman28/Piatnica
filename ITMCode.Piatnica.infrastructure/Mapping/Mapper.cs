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
            #endregion

            #region From Bll to ApiModels

            CreateMap<OrderBllModel, OrderApiModel>().ReverseMap();

            CreateMap<UpdateDelayDto, OrderBllModel>().ReverseMap();
            CreateMap<OrderEntryDto, OrderEntryBllModel>().ReverseMap();
            CreateMap<OrderStateDto, OrderStateBllModel>().ReverseMap();
            CreateMap<LocationHistoryDto, LocationHistoryBllModel>().ReverseMap();

            #endregion





        }
    }
}
