using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.ActionFiters
{
	public class RequestLoggingActionFilter : IAsyncActionFilter
	{
		public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			await next();
		}
	}
}
