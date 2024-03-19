namespace AssignmentSWD.API.Middlewares
{
    public interface IRequestHandler
    {
        Task HandleAsync(HttpContext context, RequestDelegate next);
        IRequestHandler SetNextHandler(IRequestHandler nextHandler);
    }
}
