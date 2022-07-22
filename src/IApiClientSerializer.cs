namespace Ivvy.API
{
    public interface IApiClientSerializer
    {
        string Serialize(object requestData);
    }
}