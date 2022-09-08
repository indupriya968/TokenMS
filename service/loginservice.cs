using System.Security.Claims;

namespace authentication.service
{
    public class loginservice :ILogin
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public loginservice(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        public string GetUserName()
        {
            var result = string.Empty;

            if (httpContextAccessor.HttpContext != null)
            {
                result = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
