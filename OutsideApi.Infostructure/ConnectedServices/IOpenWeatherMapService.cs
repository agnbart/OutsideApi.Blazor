using OutsideApi.Domain;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public interface IOpenWeatherMapService
    {
        Task<OpenWeatherMap> Retrive(string location, string appId);
    }
}