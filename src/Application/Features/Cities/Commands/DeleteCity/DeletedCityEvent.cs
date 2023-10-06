using Domain.Entities;
using MediatR;

namespace Application.Features.Cities.Commands.DeleteCity;

public class DeletedCityEvent: INotification
{
    public City City { get; set; }

    public DeletedCityEvent()
    {
        
    }

    public DeletedCityEvent(City city)
    {
        City = city;
    }
}