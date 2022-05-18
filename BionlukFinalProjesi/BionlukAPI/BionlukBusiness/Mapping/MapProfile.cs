using AutoMapper;
using Bionluk.DataTransferObjects.Responses;
using Bionluk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bionluk.Business.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<User, UserDisplayResponse>();
        }
    }
}
