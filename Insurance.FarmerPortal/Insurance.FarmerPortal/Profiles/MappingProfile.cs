using AutoMapper;
using Model = Insurance.FarmerPortal.Models;
using Entity = Insurance.FarmerPortal.Bpl.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Insurance.FarmerPortal.Profiles
{
    public static class AddAutoMapperExtension
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model.User, Entity.User>().ReverseMap();
            CreateMap<Model.ContactDetail, Entity.ContactDetail>().ReverseMap();
            CreateMap<Model.Address, Entity.Address>().ReverseMap();
            CreateMap<Model.ContactType, Entity.ContactType>().ReverseMap();
            CreateMap<Model.Gender, Entity.Gender>().ReverseMap();
            CreateMap<Model.Status, Entity.Status>().ReverseMap();
        }
    }
}
