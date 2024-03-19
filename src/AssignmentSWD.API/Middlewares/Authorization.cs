namespace AssignmentSWD.API.Middlewares
{
    public class Authorization : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public IRequestHandler SetNextHandler(IRequestHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return nextHandler;
        }

        public async Task HandleAsync(HttpContext context, RequestDelegate next)
        {
            // Xử lý quyền truy cập ở đây

            await _nextHandler.HandleAsync(context, next);
        }
    }
}
