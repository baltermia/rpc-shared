using System.Text.Json.Serialization;

namespace Balter.Rpc.Shared;

public class Response<TResult>
{
    [JsonPropertyName("jsonrpc")]
    public string JsonRpc { get; set; } = string.Empty;

    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("result")]
    public TResult? Result { get; set; }

    [JsonPropertyName("error")]
    public object? Error { get; set; } = null;
}