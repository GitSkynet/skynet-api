using DtoService.GoogleBooks;

namespace DomainService.Contracts
{
    public interface IGoogleBooksContract
    {
        Task<List<VolumeDTO>> GetVolumeByID(string bookID);

        Task<VolumeListDTO> GetVolumesByKeyword(string keywordToSearch);
    }
}
