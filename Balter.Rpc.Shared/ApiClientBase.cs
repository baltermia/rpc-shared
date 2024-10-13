namespace Balter.Rpc.Shared;

public abstract class ApiClientBase(string rpcUrl) : IDisposable
{
    protected readonly IJsonRpcClient _rpc = new JsonRpcClient(rpcUrl);

    public void Dispose()
    {
        _rpc.Dispose();
    }
}
