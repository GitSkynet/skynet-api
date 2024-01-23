using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Contracts.GoogleBooksContracts
{
    public interface IGoogleBooksApplicationService
    {
        public Task<List<GoogleBooksVolumeViewModel>> GetVolumeByID(string bookID);

        public Task<List<GoogleBooksVolumeViewModel>> GetVolumesByKeyword(string keyword);
    }
}
