using Domain.Entities;
using MediatR;

namespace Application.Features.Cities.Commands.CreateCity;

public class CreatedCityEvent: INotification
{
    public City City { get; set; }

    public CreatedCityEvent()
    {
        
    }

    public CreatedCityEvent(City city)
    {
        City = city;
    }
}