using AutoMapper;
using Domain.Entities;

namespace Application.Features.Users.Commands.Register;

public class RegisterMapper: Profile
{
    public RegisterMapper()
    {
        CreateMap<RegisterCommand, User>();
    }
}