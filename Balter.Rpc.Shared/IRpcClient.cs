namespace Balter.Rpc.Shared;

public interface IRpcClient : IDisposable
{
    public Task<Response<TResponse>?> SendRequestAsync<TResponse>(string method, IRequestParams data);
}

