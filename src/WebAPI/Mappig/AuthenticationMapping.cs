using System.ComponentModel.Design;
using Application.Common.Models;
using AutoMapper;
using WebAPI.Responses;

namespace WebAPI.Mappig;

public class AuthenticationMapping: Profile
{
    public AuthenticationMapping()
    {
        CreateMap<AuthenticationResult, AuthenticationResponse>()
            .ForMember(dest => dest.Token, src => src
                .MapFrom(opt => opt.Token))
            .ForMember(dest => dest.UserId, src => src
                .MapFrom(opt => opt.User.UserId))
            .ForMember(dest => dest.UserName, src => src
                .MapFrom(opt => opt.User.UserName))
            .ForMember(dest => dest.Role, src => src
                .MapFrom(opt => opt.User.Role));
        
    }
}