using AutoMapper;
using NetWebApi_Learning.Model.Domain;
using NetWebApi_Learning.Model.DTO;

namespace NetWebApi_Learning.Profiles
{
    public class RegionProfile :Profile
    {
        public RegionProfile()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
        }
    }
}
