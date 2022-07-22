namespace Ivvy.API
{
    public interface IApiClientDeserializer
    {
        ResultOrError<T> Deserialize<T>(string encodedMessage) where T : new();
    }
}