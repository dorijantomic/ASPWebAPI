using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApiDemo.Models;
using WebApiDemo.Models.Repository;


public class Shirt_ValidateShirtObjectFilterAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        base.OnActionExecuting(context);
        var shirt = context.ActionArguments["shirt"] as ShirtModel;

        if (shirt == null)
        {
            context.ModelState.AddModelError("Shirt", "Shirt is invalid.");
            var problemDetails = new ValidationProblemDetails(context.ModelState)
            {
                Status = StatusCodes.Status400BadRequest
            };
            context.Result = new BadRequestObjectResult(problemDetails);
        }
        else
        {
            var existingShirt = ShirtRepository.GetShirtByProperties(shirt.Brand, shirt.Gender, shirt.Colour, shirt.Size);
            if (existingShirt != null)
            {
                context.ModelState.AddModelError("Shirt", "Shirt already exists.");
                var problemDetails = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status400BadRequest
                };
                context.Result = new ConflictObjectResult(problemDetails);
            }
        };


    }
}
