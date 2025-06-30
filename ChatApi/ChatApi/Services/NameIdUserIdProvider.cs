using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace ChatApi.Services
{
    public class NameIdUserIdProvider : IUserIdProvider
    {
        public string GetUserId(HubConnectionContext connection)
            => connection.User?.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
