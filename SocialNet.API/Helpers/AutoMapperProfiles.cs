using System.Linq;
using AutoMapper;
using MET.API.Helpers;
using MET.API.Models;
using SocialNet.API.Dtos;

namespace SocialNet.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                    .ForMember(des => des.PhotoUrl, opt => opt.MapFrom(src => src.Photo.FirstOrDefault(p => p.IsMain).Url))
                    .ForMember(des => des.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<User, UserForDetailsDto>()
                    .ForMember(des => des.PhotoUrl, opt => opt.MapFrom(src => src.Photo.FirstOrDefault(p => p.IsMain).Url))
                    .ForMember(des => des.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge())); 
            CreateMap<Photo, PhotosForDetailsDto>();
        }
        
    }
}