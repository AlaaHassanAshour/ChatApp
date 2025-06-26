namespace ChatApi.Hubs;

using Microsoft.AspNetCore.SignalR;

public class NameUserIdProvider : IUserIdProvider
{
    public string GetUserId(HubConnectionContext connection)
    {
        return connection.User?.FindFirst("sub")?.Value ?? connection.User?.Identity?.Name;
    }
}