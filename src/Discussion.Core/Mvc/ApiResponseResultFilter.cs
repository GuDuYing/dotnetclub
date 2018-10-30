using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Discussion.Core.Mvc
{
    public class ApiResponseResultFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is ObjectResult objectResult &&
                !(objectResult.Value is ApiResponse))
            {
                objectResult.Value = ApiResponse.ActionResult(objectResult.Value);
            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
}