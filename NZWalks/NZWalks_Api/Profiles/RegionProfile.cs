﻿using AutoMapper;
namespace NZWalks_Api.Profiles;

public class RegionProfile : Profile
{
   public RegionProfile() 
    {

        CreateMap<Models.Domain.Region, Models.DTO.Region>()
               .ReverseMap();
        CreateMap<Models.Domain.User, Models.DTO.User>().ReverseMap();

    }

   
}
