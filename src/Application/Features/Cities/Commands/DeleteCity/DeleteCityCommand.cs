using MediatR;

namespace Application.Features.Cities.Commands.DeleteCity;

public class DeleteCityCommand: IRequest<bool>
{
    public Guid Id { get; set; }

    public DeleteCityCommand()
    {
        
    }

    public DeleteCityCommand(Guid id)
    {
        Id = id;
    }
}