using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MessWala.Application.Restaurant.Model
{
    public class RestaurantDto
    {
        public string Name { get; set; }

        public static Expression<Func<Data.Restaurant, RestaurantDto>> Projection
        {
            get
            {
                return c => new RestaurantDto
                {
                     Name = c.Name
                };
            }
        }
    }
}
