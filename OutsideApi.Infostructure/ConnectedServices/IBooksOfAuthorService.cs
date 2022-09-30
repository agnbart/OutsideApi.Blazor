using OutsideApi.Domain;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public interface IBooksOfAuthorService
    {
        Task<List<BooksOfAuthorMap>> Retrive();
    }
}