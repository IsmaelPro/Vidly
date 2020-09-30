using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Dtos;
using WebApplication2.Models;

namespace WebApplication2.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Rental, RentalDto>();


            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
               .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<MembershipTypeDto, MembershipType>()
               .ForMember(c => c.Id, opt => opt.Ignore());

             Mapper.CreateMap<RentalDto, Rental>()
               .ForMember(c => c.Id, opt => opt.Ignore());



        }
    }
}