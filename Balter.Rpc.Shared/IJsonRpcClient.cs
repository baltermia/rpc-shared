namespace Balter.Rpc.Shared;

public interface IJsonRpcClient : IDisposable
{
    public Task<Response<TResponse>?> GetFromJsonAsync<TResponse>(string method, IRequestParams data);
}

