using OutsideApi.Domain;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public interface IBitcoinMapService
    {
        Task<BitcoinMap> Retrive();
    }
}