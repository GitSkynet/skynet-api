using DataAccess.RESTServices.GoogleBooks.Interfaces;
using Entities.GoogleBooks;
using Repository.Contracts.GoogleBooks;

namespace Repositories.GoogleBooksRepo
{
    public class GoogleBooksAssociationRepo : IGoogleBooksAssociationRepo
    {
        private readonly IConsumingGoogleBooksQueryService consumingGoogleBooksQueryService;

        public GoogleBooksAssociationRepo(IConsumingGoogleBooksQueryService ConsumingGoogleBooksQueryService)
        {
            this.consumingGoogleBooksQueryService = ConsumingGoogleBooksQueryService;
        }

        public async Task<List<GoogleBooksEntityVolume>> GetVolumeByID(string bookID)
        {
            List<GoogleBooksEntityVolume> VolumeList = new List<GoogleBooksEntityVolume>();
            try
            {
                VolumeList = await consumingGoogleBooksQueryService.GetVolumeByID(bookID);
                if (!VolumeList.Any())
                {
                    throw new Exception("Google Books API: No volume found with ID provided");
                }
                return VolumeList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public async Task<GoogleBooksVolumeList> GetVolumesByKeyword(string keywordToSearch)
        {
            GoogleBooksVolumeList VolumeList = new GoogleBooksVolumeList();
            try
            {
                VolumeList = await consumingGoogleBooksQueryService.GetVolumesByKeyword(keywordToSearch);
                return VolumeList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
