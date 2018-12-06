using MediatR;
using MessWala.Application.Restaurant.Model;
using MessWala.Application.Restaurant.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Threading.Tasks;

namespace MessWala.Web.Pages.Restaurant
{
    public class CreateModel : PageModel
    {
        private readonly IMediator mediatr;
        private readonly ILoggerFactory loggerFactory;
        public RestaurantDto rstDto;

        public CreateModel(IMediator mediatr, ILoggerFactory loggerFactory)
        {
            this.mediatr = mediatr;
            this.loggerFactory = loggerFactory;
        }

        public async Task OnGet()
        {
            var article = await mediatr.Send(new GetRestaurantListQuery(rstDto));
        }
    }
}