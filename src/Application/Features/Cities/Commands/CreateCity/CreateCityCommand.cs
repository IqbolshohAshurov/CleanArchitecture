using MediatR;

namespace Application.Features.Cities.Commands.CreateCity;

public class CreateCityCommand: IRequest<bool>
{
    public string Name { get; set; }

    public CreateCityCommand()
    {
        
    }

    public CreateCityCommand(string name)
    {
        Name = name;
    }
}