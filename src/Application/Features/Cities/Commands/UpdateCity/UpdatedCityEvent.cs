using Domain.Entities;
using MediatR;

namespace Application.Features.Cities.Commands.UpdateCity;

public class UpdatedCityEvent: INotification
{
    public City City { get; set; }

    public UpdatedCityEvent()
    {
        
    }

    public UpdatedCityEvent(City city)
    {
        City = city;
    }
}