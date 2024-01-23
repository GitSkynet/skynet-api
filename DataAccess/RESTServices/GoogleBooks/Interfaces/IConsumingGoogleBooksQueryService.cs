using Entities.GoogleBooks;

namespace DataAccess.RESTServices.GoogleBooks.Interfaces
{
    public interface IConsumingGoogleBooksQueryService
    {
        public Task<List<GoogleBooksEntityVolume>> GetVolumeByID(string bookID);

        public Task<GoogleBooksVolumeList> GetVolumesByKeyword(string keywordToSearch);
    }
}
