using Entities.GoogleBooks;

namespace Repository.Contracts.GoogleBooks
{
    public interface IGoogleBooksAssociationRepo
    {
        Task<List<GoogleBooksEntityVolume>> GetVolumeByID(string bookID);

        Task<GoogleBooksVolumeList> GetVolumesByKeyword(string keywordToSearch);
    }
}
