using MediatR;
using MessWala.Application.Restaurant.Model;
using MessWala.Application.Restaurant.Queries.GetRestaurantsList;
using System;
using System.Collections.Generic;
using System.Text;

namespace MessWala.Application.Restaurant.Queries
{
    public class GetRestaurantListQuery : IRequest<RestaurantsListViewModel>
    {
        public GetRestaurantListQuery(RestaurantDto rst)
        {

        }
    }
}
