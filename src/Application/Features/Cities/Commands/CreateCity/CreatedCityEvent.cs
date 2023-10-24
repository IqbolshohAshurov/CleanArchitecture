using Domain.Entities;
using MediatR;

namespace Application.Features.Cities.Commands.CreateCity;

public class CreatedCityEvent: INotification
{
    public CreatedCityEvent() { }

    public CreatedCityEvent(City city)
    {
        City = city;
    }

    public City City { get; set; }
}