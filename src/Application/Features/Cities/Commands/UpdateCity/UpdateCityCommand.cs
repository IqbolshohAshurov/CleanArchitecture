using MediatR;

namespace Application.Features.Cities.Commands.UpdateCity;

public class UpdateCityCommand: IRequest<bool>
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }

    public UpdateCityCommand()
    {
        
    }

    public UpdateCityCommand(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}