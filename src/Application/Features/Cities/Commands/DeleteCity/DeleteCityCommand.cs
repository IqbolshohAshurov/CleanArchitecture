using MediatR;

namespace Application.Features.Cities.Commands.DeleteCity;

public class DeleteCityCommand: IRequest<bool>
{
    public DeleteCityCommand() {}

    public DeleteCityCommand(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}