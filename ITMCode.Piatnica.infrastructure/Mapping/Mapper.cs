using AutoMapper;
using ITMCode.Piatnica.Api.Models;
using ITMCode.Piatnica.Bll.Models;
using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessToBusiness.Infrastucture.Mapping
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
            #endregion





        }
    }
}
