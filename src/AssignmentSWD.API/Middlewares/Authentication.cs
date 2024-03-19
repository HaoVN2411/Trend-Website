namespace AssignmentSWD.API.Middlewares
{
    public class Authentication : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public IRequestHandler SetNextHandler(IRequestHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return nextHandler;
        }

        public async Task HandleAsync(HttpContext context, RequestDelegate next)
        {
            // Xử lý xác thực ở đây

            await _nextHandler.HandleAsync(context, next);
        }
    }
}
