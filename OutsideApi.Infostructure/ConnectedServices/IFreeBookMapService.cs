using OutsideApi.Domain;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public interface IFreeBookMapService
    {
        Task<List<FreeBookMap>> Retrive();
    }
}