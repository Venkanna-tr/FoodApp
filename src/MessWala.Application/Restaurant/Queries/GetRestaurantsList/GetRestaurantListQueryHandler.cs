using MediatR;
using MessWala.Application.Restaurant.Model;
using MessWala.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MessWala.Application.Restaurant.Queries
{
    public class GetRestaurantListQueryHandler : IRequest<RestaurantDto>
    {
        private readonly SampleDbContext context;

        public GetRestaurantListQueryHandler(SampleDbContext context)
        {
            this.context = context;
        }

        public async Task<List<RestaurantDto>> Handle(RestaurantDto request, CancellationToken cancellationToken)
        {
            return await context.Restaurants
                .Select(RestaurantDto.Projection)
                .ToListAsync(cancellationToken);
        }
    }
}
